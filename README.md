# Amazfit Bip Tools
## Mac Compatible

This package allows you to run [valeronn's Amazfit Bip Tools](https://bitbucket.org/valeronm/amazfitbiptools/src/master/WatchFace.Parser/Reader.cs) on a Mac.

The decompiled images and json file can be used with this [Online WatchFace Editor]( https://amazfitwatchfaces.com/editor/watchfaceEditor/?bip) in order to create your custom watch face.

## Install

**Requirements**: Brew must be installed before this can be used. Install [`brew`](https://brew.sh) by following the instructions at: https://brew.sh/

1. Clone this repository with `git clone git@github.com:tamsanh/amazfitbiptools-mac.git`.
2. Enter into the directory with `cd amazfitbiptools-mac`.
3. Execute the `./run.sh` to install and use.

After installation, you can simply run `./run.sh` to execute the `WatchFace.exe` file on your Mac.

## Usage

`./run.sh`

### Decompiling a bin file.

```bash
./run.sh example/3472.bin
```

This will extract your bin file into the images and json file that you can upload to the [Online WatchFace Editor](https://amazfitwatchfaces.com/editor/watchfaceEditor/?bip). The online editor will allow you to move and place your image files with a live preview of your changes.

When you are finished placing the images, save the `json` output visible on the `EDIT` tab in the same folder as your image files.

### Compiling a json file.

```bash
./run.sh example/3472/3472.json
```

This will generate a `.bin` file from the `.json` data which can be installed into a bip.

### Installing to bip

#### iOS

1. Download the [`AmazTools`](https://apps.apple.com/us/app/amaztools/id1386033880) app on your iOS device.
2. Open your `Mi Fit` app and let it run in the background
3. Open your `AmazTools` app and set it up to connect it to the Bip.
2. Ctrl-Click your new `.bin` file on your mac
3. AirDrop the `.bin` file to your iOS device
4. On the iOS, open the `.bin` file with `AmazTools`.
5. Click `Install` to install it to your watch.

If `AmazTools` indicates a developer error, make sure your `Mi Fit` app is running in the background.
