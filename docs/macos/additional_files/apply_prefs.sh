#!/bin/zsh

# Sleep for 5 seconds by default
# Custom number can be passed in though
/bin/sleep ${1:-5}

/bin/cp -r '/Library/EdgeTweaker/prefs/com.microsoft.Edge_mandatory.plist' '/Library/Managed Preferences/com.microsoft.Edge.plist'
/bin/cp -r '/Library/EdgeTweaker/prefs/com.microsoft.Edge_recommended.plist' '/Library/Preferences/com.microsoft.Edge.plist'
