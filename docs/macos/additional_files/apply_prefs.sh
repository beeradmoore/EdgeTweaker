#!/bin/zsh

# Sleep for 5 seconds by default
# Custom number can be passed in though
/bin/sleep ${1:-5}

/bin/cp -r '/Library/EdgeTweaker/prefs/mandatory/com.microsoft.Edge.plist' '/Library/Managed Preferences/com.microsoft.Edge.plist'
/bin/cp -r '/Library/EdgeTweaker/prefs/recommended/com.microsoft.Edge.plist' '/Library/Preferences/com.microsoft.Edge.plist'
