#!/bin/bash

CURR_DIR=$(cd `dirname $0`; pwd)

cd $CURR_DIR

watch_face_dir="./WatchFace/bin/Debug/WatchFace.exe"

if [ -e ${watch_face_dir} ]; then
    mono ${watch_face_dir} "$@" | sed 's#WatchFace.exe#./run.sh#g'
    exit 0
fi

echo "WatchFace.exe is not setup. Begin compilation?"
printf "[Y/n]? "
read response

lowered_response=`echo $response | tr '[:upper:]' '[:lower:]'`

if [[ "${lowered_response}" == n* ]]; then
    echo "Abandoning compilation."
    exit 0
fi

echo "Beginning compiation"

brew --version > /dev/null

if [ $? -ne 0 ]; then
    echo "FATAL: brew must be installed for this setup script to work."
    exit 1
fi

ls

brew install mono nuget mono-libgdiplus
nuget restore Amazfit.sln
msbuild Amazfit.sln -restore:True

./run.sh $@

