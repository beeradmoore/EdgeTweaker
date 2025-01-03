#!/bin/bash

set -e

if [ "$(id -u)" -ne 0 ]; then
    echo "Error: This script must be run as root"
    echo "Please run: sudo ./install.sh"
    exit 1
fi

umask 022
mkdir -p '/Library/EdgeTweaker/scripts/'
mkdir -p '/Library/EdgeTweaker/prefs/mandatory/'
mkdir -p '/Library/EdgeTweaker/prefs/recommended/'
mkdir -p '/Library/Managed Preferences/'


cp 'mandatory/com.microsoft.Edge.plist' '/Library/EdgeTweaker/prefs/mandatory/com.microsoft.Edge.plist'
cp 'recommended/com.microsoft.Edge.plist' '/Library/EdgeTweaker/prefs/recommended/com.microsoft.Edge.plist'
cp 'additional_files/apply_prefs.sh' '/Library/EdgeTweaker/scripts/'
cp 'additional_files/com.edgetweaker.prefs.plist' '/Library/LaunchDaemons/'
launchctl load -w /Library/LaunchDaemons/com.edgetweaker.prefs.plist

chmod 744 /Library/EdgeTweaker/scripts/apply_prefs.sh
/Library/EdgeTweaker/scripts/apply_prefs.sh 0

echo "If Edge was previously configured you may need to reboot to see the changes"
