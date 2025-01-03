#!/bin/bash

set -e

if [ "$(id -u)" -ne 0 ]; then
    echo "Error: This script must be run as root"
    echo "Please run: sudo ./uninstall.sh"
    exit 1
fi

rm -rf '/Library/EdgeTweaker/'
rm -f '/Library/Preferences/com.microsoft.Edge.plist'
rm -f '/Library/Managed Preferences/com.microsoft.Edge.plist'
rm -f '/Library/LaunchDaemons/com.edgetweaker.prefs.plist'
