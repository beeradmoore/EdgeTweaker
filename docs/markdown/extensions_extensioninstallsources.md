---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ExtensionInstallSources | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/extensioninstallsources
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure extension and user script install sources'
locale: en-us
document_id: 11423260-1c06-ae68-96e3-a427a32757b9
document_version_independent_id: 11423260-1c06-ae68-96e3-a427a32757b9
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ExtensionInstallSources.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/ExtensionInstallSources.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 259
asset_id: microsoft-edge-policies/extensioninstallsources
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ExtensionInstallSources.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 9de09770-8a23-1c32-e360-5c96390d3a40
---

# Microsoft Edge Browser Policy Documentation ExtensionInstallSources | Microsoft Learn

## Configure extension and user script install sources

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Define URLs that can install extensions and themes.

Define URLs that can install extensions and themes directly without having to drag and drop the packages to the edge://extensions page.

Each item in this list is an extension-style match pattern (see https://go.microsoft.com/fwlink/?linkid=2095039). Users can easily install items from any URL that matches an item in this list. Both the location of the \*.crx file and the page where the download is started from (in other words, the referrer) must be allowed by these patterns. Don't host the files at a location that requires authentication.

The [ExtensionInstallBlocklist](extensioninstallblocklist) policy takes precedence over this policy. Any extensions that's on the blocklist won't be installed, even if it comes from a site on this list.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ExtensionInstallSources
- GP name: Configure extension and user script install sources
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Extensions
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://corp.contoso.com/*
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallSources
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallSources\1 =

```
https://corp.contoso.com/*
```

## Mac information and settings

- Preference Key name: ExtensionInstallSources
- Example value:

```xml
<array>
  <string>https://corp.contoso.com/*</string>
</array>
```