---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ExtensionExtendedBackgroundLifetimeForPortConnectionsToUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/extensionextendedbackgroundlifetimeforportconnectionstourls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure a list of origins that grant an extended background lifetime to connecting extensions.'
locale: en-us
document_id: 3daaace6-8319-020f-d050-06d0ce26f4c2
document_version_independent_id: 3daaace6-8319-020f-d050-06d0ce26f4c2
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ExtensionExtendedBackgroundLifetimeForPortConnectionsToUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/ExtensionExtendedBackgroundLifetimeForPortConnectionsToUrls.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 255
asset_id: microsoft-edge-policies/extensionextendedbackgroundlifetimeforportconnectionstourls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ExtensionExtendedBackgroundLifetimeForPortConnectionsToUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 6a2a45dc-9263-f041-a3d1-35c4c05acd5e
---

# Microsoft Edge Browser Policy Documentation ExtensionExtendedBackgroundLifetimeForPortConnectionsToUrls | Microsoft Learn

## Configure a list of origins that grant an extended background lifetime to connecting extensions.

## Supported versions

- Windows: ≥ 128
- macOS: ≥ 128
- Android: Not supported
- iOS: Not supported

## Description

Extensions that connect to one of these origins keep running as long as the port is connected. If unset, the policy's default values are used. These are the app origins that offer software development kits (SDKs) that are known to not offer the possibility of restarting a closed connection to a previous state:

- Smart Card Connector
- Citrix Receiver (stable, beta, back-up)
- VMware Horizon (stable, beta)

If set, the default value list is extended with the newly configured values. The defaults and policy-provided entries grant the exception to the connecting extensions as long as the port is connected.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ExtensionExtendedBackgroundLifetimeForPortConnectionsToUrls
- GP name: Configure a list of origins that grant an extended background lifetime to connecting extensions.
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Extensions
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
chrome-extension://abcdefghijklmnopabcdefghijklmnop/
```

```
chrome-extension://bcdefghijklmnopabcdefghijklmnopa/
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\ExtensionExtendedBackgroundLifetimeForPortConnectionsToUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\ExtensionExtendedBackgroundLifetimeForPortConnectionsToUrls\1 =

```
chrome-extension://abcdefghijklmnopabcdefghijklmnop/
```

SOFTWARE\Policies\Microsoft\Edge\ExtensionExtendedBackgroundLifetimeForPortConnectionsToUrls\2 =

```
chrome-extension://bcdefghijklmnopabcdefghijklmnopa/
```

## Mac information and settings

- Preference Key name: ExtensionExtendedBackgroundLifetimeForPortConnectionsToUrls
- Example value:

```xml
<array>
  <string>chrome-extension://abcdefghijklmnopabcdefghijklmnop/</string>
  <string>chrome-extension://bcdefghijklmnopabcdefghijklmnopa/</string>
</array>
```