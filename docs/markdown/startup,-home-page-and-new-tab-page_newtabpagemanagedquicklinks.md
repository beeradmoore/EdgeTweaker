---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NewTabPageManagedQuickLinks | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/newtabpagemanagedquicklinks
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
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set new tab page quick links'
locale: en-us
document_id: b468707c-4ab4-a91b-1bd6-cd6f3af2b7cc
document_version_independent_id: b468707c-4ab4-a91b-1bd6-cd6f3af2b7cc
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NewTabPageManagedQuickLinks.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/NewTabPageManagedQuickLinks.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 426
asset_id: microsoft-edge-policies/newtabpagemanagedquicklinks
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NewTabPageManagedQuickLinks.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ac796762-587a-3eb2-2f70-939e55dd09a2
---

# Microsoft Edge Browser Policy Documentation NewTabPageManagedQuickLinks | Microsoft Learn

## Set new tab page quick links

## Supported versions

- Windows: ≥ 79
- macOS: ≥ 79
- Android: Not supported
- iOS: Not supported

## Description

By default, Microsoft Edge displays quick links on the new tab page from user-added shortcuts and top sites based on browsing history. With this policy, you can configure up to three quick link tiles on the new tab page, expressed as a JSON object:

[ { "url": "https://www.contoso.com", "title": "Contoso Portal", "pinned": true/false }, ... ]

The 'url' field is required; 'title' and 'pinned' are optional. If 'title' isn't provided, the URL is used as the default title. If 'pinned' isn't provided, the default value is false.

Microsoft Edge presents these tiles in the order listed, from left to right, with all pinned tiles displayed ahead of nonpinned tiles.

If you set this policy as mandatory, the 'pinned' field is ignored and all tiles are pinned. The tiles can't be deleted by the user and always appear at the front of the quick links list.

If you set this policy as recommended, pinned tiles remain in the list but the user has the ability to edit and delete them. Quick link tiles that aren't pinned behave like default top sites and are pushed off the list if other websites are visited more frequently. When applying nonpinned links via this policy to an existing browser profile, the links don't appear at all, depending on how they rank compared to the user's browsing history.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: NewTabPageManagedQuickLinks
- GP name: Set new tab page quick links
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Startup, home page and new tab page
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Startup, home page and new tab page
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"pinned": true, "title": "Contoso Portal", "url": "https://contoso.com"}, {"title": "Fabrikam", "url": "https://fabrikam.com"}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: NewTabPageManagedQuickLinks
- Value type: REG\_SZ

#### Example registry value

```
[{"pinned": true, "title": "Contoso Portal", "url": "https://contoso.com"}, {"title": "Fabrikam", "url": "https://fabrikam.com"}]
```

#### Expanded example registry value

```
[
  {
    "pinned": true,
    "title": "Contoso Portal",
    "url": "https://contoso.com"
  },
  {
    "title": "Fabrikam",
    "url": "https://fabrikam.com"
  }
]
```

## Mac information and settings

- Preference Key name: NewTabPageManagedQuickLinks
- Example value:

```xml
<key>NewTabPageManagedQuickLinks</key>
<array>
  <dict>
    <key>pinned</key>
    <true/>
    <key>title</key>
    <string>Contoso Portal</string>
    <key>url</key>
    <string>https://contoso.com</string>
  </dict>
  <dict>
    <key>title</key>
    <string>Fabrikam</string>
    <key>url</key>
    <string>https://fabrikam.com</string>
  </dict>
</array>
```