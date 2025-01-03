#!/bin/bash

set -e

if [ "$(id -u)" -ne 0 ]; then
    echo "Error: This script must be run as root"
    echo "Please run: sudo ./install.sh"
    exit 1
fi

umask 022
mkdir -p '/Library/EdgeTweaker/scripts/'
mkdir -p '/Library/EdgeTweaker/prefs/'
mkdir -p '/Library/Managed Preferences/'


cp 'mandatory/com.microsoft.Edge.plist' '/Library/EdgeTweaker/prefs/com.microsoft.Edge_mandatory.plist'
cp 'recommended/com.microsoft.Edge.plist' '/Library/EdgeTweaker/prefs/com.microsoft.Edge_recommended.plist'
cp 'additional_files/apply_prefs.sh' '/Library/EdgeTweaker/scripts/'
cp 'additional_files/com.edgetweaker.prefs.plist' '/Library/LaunchDaemons/'
launchctl load -w /Library/LaunchDaemons/com.edgetweaker.prefs.plist

chmod 744 /Library/EdgeTweaker/scripts/apply_prefs.sh
/Library/EdgeTweaker/scripts/apply_prefs.sh 0
