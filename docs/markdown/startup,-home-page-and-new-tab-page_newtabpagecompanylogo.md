---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NewTabPageCompanyLogo | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/newtabpagecompanylogo
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: jalam
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-05-20T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set new tab page company logo (obsolete)'
locale: en-us
document_id: 9d3b9127-97be-6b28-9cf2-dd1ef7d857a9
document_version_independent_id: 9d3b9127-97be-6b28-9cf2-dd1ef7d857a9
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NewTabPageCompanyLogo.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/NewTabPageCompanyLogo.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 484
asset_id: microsoft-edge-policies/newtabpagecompanylogo
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NewTabPageCompanyLogo.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 69155bf3-75bc-b782-eca0-e2d9cd1f5f61
---

# Microsoft Edge Browser Policy Documentation NewTabPageCompanyLogo | Microsoft Learn

## Set new tab page company logo (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 85.

## Supported versions

- Windows: 79-85
- macOS: 79-85
- Android: Not supported
- iOS: Not supported

## Description

This policy didn't work as expected due to changes in operational requirements. Therefore, it's obsolete and shouldn't be used.

Specifies the company logo that's to be used on the new tab page in Microsoft Edge.

The policy should be configured as a string that expresses the logo(s) in JSON format. For example: { "default\_logo": { "url": "https://www.contoso.com/logo.png", "hash": "cd0aa9856147b6c5b4ff2b7dfee5da20aa38253099ef1b4a64aced233c9afe29" }, "light\_logo": { "url": "https://www.contoso.com/light\_logo.png", "hash": "517d286edb416bb2625ccfcba9de78296e90da8e32330d4c9c8275c4c1c33737" } }

You configure this policy by specifying the URL from which Microsoft Edge can download the logo and its cryptographic hash (SHA-256), which is used to verify the integrity of the download. The logo must be in PNG or SVG format, and its file size must not exceed 16 MB. The logo is downloaded and cached, and it will be redownloaded whenever the URL or the hash changes. The URL must be accessible without any authentication.

The 'default\_logo' is required and used when there's no background image. If 'light\_logo' is provided, it's used when the user's new tab page has a background image. We recommend a horizontal logo with a transparent background that's left-aligned and vertically centered. The logo should have a minimum height of 32 pixels and an aspect ratio from 1:1 to 4:1. The 'default\_logo' should have proper contrast against a white/black background, while the 'light\_logo' should have proper contrast against a background image.

If you enable this policy, Microsoft Edge downloads and shows the specified logo(s) on the new tab page. Users can't override or hide the logo(s).

If you disable or don't configure this policy, Microsoft Edge shows no company logo or a Microsoft logo on the new tab page.

For help with determining the SHA-256 hash, see [Get-FileHash](/en-us/powershell/module/microsoft.powershell.utility/get-filehash).

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: NewTabPageCompanyLogo
- GP name: Set new tab page company logo (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Startup, home page and new tab page
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
{"default_logo": {"hash": "cd0aa9856147b6c5b4ff2b7dfee5da20aa38253099ef1b4a64aced233c9afe29", "url": "https://www.contoso.com/logo.png"}, "light_logo": {"hash": "517d286edb416bb2625ccfcba9de78296e90da8e32330d4c9c8275c4c1c33737", "url": "https://www.contoso.com/light_logo.png"}}
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: NewTabPageCompanyLogo
- Value type: REG\_SZ

#### Example registry value

```
{"default_logo": {"hash": "cd0aa9856147b6c5b4ff2b7dfee5da20aa38253099ef1b4a64aced233c9afe29", "url": "https://www.contoso.com/logo.png"}, "light_logo": {"hash": "517d286edb416bb2625ccfcba9de78296e90da8e32330d4c9c8275c4c1c33737", "url": "https://www.contoso.com/light_logo.png"}}
```

#### Expanded example registry value

```
{
  "default_logo": {
    "hash": "cd0aa9856147b6c5b4ff2b7dfee5da20aa38253099ef1b4a64aced233c9afe29",
    "url": "https://www.contoso.com/logo.png"
  },
  "light_logo": {
    "hash": "517d286edb416bb2625ccfcba9de78296e90da8e32330d4c9c8275c4c1c33737",
    "url": "https://www.contoso.com/light_logo.png"
  }
}
```

## Mac information and settings

- Preference Key name: NewTabPageCompanyLogo
- Example value:

```xml
<key>NewTabPageCompanyLogo</key>
<dict>
  <key>default_logo</key>
  <dict>
    <key>hash</key>
    <string>cd0aa9856147b6c5b4ff2b7dfee5da20aa38253099ef1b4a64aced233c9afe29</string>
    <key>url</key>
    <string>https://www.contoso.com/logo.png</string>
  </dict>
  <key>light_logo</key>
  <dict>
    <key>hash</key>
    <string>517d286edb416bb2625ccfcba9de78296e90da8e32330d4c9c8275c4c1c33737</string>
    <key>url</key>
    <string>https://www.contoso.com/light_logo.png</string>
  </dict>
</dict>
```