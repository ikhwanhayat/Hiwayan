# Hiwayan - A Simple Media Library

This program is intended to solve one thing: To stop my 4yo kid from nagging me to 
open her favorite cartoons on the computer.

I can hardly understand which animated movies she wanted to watch some since she 
doesn't know the title and often just refer to a movie as "the bear movie" 
or "that one with elephants". So with this program, she can launch it from the 
desktop and just tap the film poster image to view it.

This is a WPF application and you need the .NET Framework to run it.

## Usage

1. Get the download from https://github.com/ikhwanhayat/Hiwayan/releases
2. Unzip it somewhere. Make a shortcut to `Hiwayan.exe` to the Desktop if you like to.
3. Edit the `Hiwayan.exe.config` to insert the movie list.
4. The path for the video file and thumbnail image is mandatory
5. Run `Hiwayan.exe`. Upon clicking/tapping the thumbnail, the default program that plays the video file will be launched.

## Configuration
```
<HiwayanConfiguration>
   <MediaList>
      <Media>
        <Path>path to first video file</Path>
        <Thumbnail>path to first poster thumbnail file</Thumbnail>
      </Media>
      <Media>
        <Path>path to second video file</Path>
        <Thumbnail>path to second poster thumbnail file</Thumbnail>
      </Media>
      <Media>
        <Path>path to n-th video file</Path>
        <Thumbnail>path to n-th poster thumbnail file</Thumbnail>
      </Media>
   </MediaList>
</HiwayanConfiguration>
```
