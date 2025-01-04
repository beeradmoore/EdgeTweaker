<p align="center">
  <img src="https://beeradmoore.github.io/EdgeTweaker/icon-large.png" width="300" />
</p>

# EdgeTweaker

EdgeTweaker is a tool that allows you to configure Microsoft Edge policies for your non-enterprise computers.

(New) Microsoft Edge launched January 15th 2020. In those 4 years since the browser has gone from being a slimmed down fast Chrome alternative to something that is just as cluttered with with junk features I don't care about (eg. [copilot](https://www.microsoft.com/en-us/edge/features/copilot?form=MA13FJ), [collections](https://support.microsoft.com/en-au/microsoft-edge/organize-your-ideas-with-collections-in-microsoft-edge-60fd7bba-6cfd-00b9-3787-b197231b507e), [sidebar](https://www.microsoft.com/en-us/edge/features/sidebar?form=MA13FJ), [split screen](https://www.microsoft.com/en-us/edge/features/split-screen?form=MA13FJ), etc)

Using EdgeTweaker you can create your own policies and easily apply them to every browser on your machine at once or take those same policies and apply on multiple computers.

## How to use

Navigate to [https://beeradmoore.github.io/EdgeTweaker/](https://beeradmoore.github.io/EdgeTweaker/) and find policies you wish to set.

Once you have created your custom set of rules download them with the `Save settings` button. This is useful if you wish to make more changes over time. If you're rather proud of your policies you can share them by submitting them as a [preset](#presets).

When you are happy with your policies, click `Export`.

### Windows

#### Registry

Both mandatory and recommended policies can be downloaded in a single `.reg` file.

When you have downloaded your `EdgeTweaker-Policies.reg` file double click it to import them.

> [!IMPORTANT]
>
> Importing new registry keys will append existing settings, overwriting where necessary. This means if you remove an option from your policies it will not be removed from the registry.
>
> It is recommended to use [EdgeRegCleanup.reg](https://beeradmoore.github.io/EdgeTweaker/windows/EdgeRegCleanup.reg) to deleted pre-existing Edge policies before importing new ones.

After applying your reg file you must go to [edge://policy](edge://policy) and click `Reload Policies` for them  to actually be loaded.

#### Group policy (ADMX)

Currently not supported. I don't know how group policies work, or what their format is. If people want them file a new issue with some info and I can add support.

### macOS

#### Installer bundle

On macOS mandatory and recommended policies are stored in separate plist files stored in different locations. One of these locations gets deleted on reboot.

The installer bundle not only comes with your two plist policy files, it also comes with a `installer.sh` script that creates a launch daemon which will restore your automatically deleted policies on boot.

To install, simply run the script as root,

```bash
sudo ./install.sh
```

There is also a `uninstall.sh` to remove any policies as well as `EdgeTweaker` settings.

```bash
sudo ./uninstall.sh
```

The source of these scripts as well as the launch daemon can be found [here](https://github.com/beeradmoore/EdgeTweaker/tree/main/docs/macos).

#### Plist (only mandatory options)

You can also download just the plist manually. It must be moved to be `/Library/Managed Preferences/com.microsoft.Edge.plist`.

> [!NOTE]
>
> This file will be deleted on reboot, it is required to have something (such as the scripts from the [installer bundle](#installer-bundle)) that will restore it on boot.

If you are using EdgeTweaker launch daemon you should move the file to `/Library/EdgeTweaker/prefs/mandatory/com.microsoft.Edge.plist` and then reboot.

#### Plist (only recommended options)

You can also download just the plist manually. It must be moved to be `/Library/Preferences/com.microsoft.Edge.plist`.

This file does not get automatically deleted on reboot. However if you are using the EdgeTweaker launch daemon it will get overwritten by your previous policy. Move this policy file to `/Library/EdgeTweaker/prefs/recommended/com.microsoft.Edge.plist` and then reboot.

### Linux

EdgeTweaker currently does not support Linux. If there is some demand for it then it can be added in the future.

### Presets

There are a few presets defined. If you have alternatives that may be useful to the community feel free to [submit a new preset](https://github.com/beeradmoore/EdgeTweaker/issues).


### How are policies updated

There is a C# projected in this repository called `EdgePolicyMarkdownParser`. It pulls in the markdown document that produces the [Microsoft Edge - Policies
](https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies) page.

Each policy is then parsed and put into a `policy-groups.json` file in the `docs` folder which is then used by the frontend site.

Because it is all managed by git each policy change should be reviewed and then the `supported` boolean should be set to true once it appears to be compatible. This prevents issues of a new data type coming out and slipping past this tool.

### Pull requests welcome

I am not a frontend developer. I don't know html, let alone all this javascript and bootstrap. Any tips/tricks/improvements are welcome.

### See also
- [TheBobPony/MSEdgeTweaker](https://github.com/TheBobPony/MSEdgeTweaker)
  - Another project aimed at improving Edge.
- [TommyTran732/Microsoft-Edge-Policies](https://github.com/TommyTran732/Microsoft-Edge-Policies)
  -  Seemingly the only place I could find to talk about macOS recommended policy locations. Also conveniently had all the information on how to create LaunchDaemon for macOS.
