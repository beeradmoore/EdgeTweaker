---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DataURLWhitespacePreservationEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/dataurlwhitespacepreservationenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: DataURL Whitespace Preservation for all media types'
locale: en-us
document_id: da4d9b2b-45f0-0c52-12ab-9aa2e20f1203
document_version_independent_id: da4d9b2b-45f0-0c52-12ab-9aa2e20f1203
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DataURLWhitespacePreservationEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/DataURLWhitespacePreservationEnabled.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 222
asset_id: microsoft-edge-policies/dataurlwhitespacepreservationenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DataURLWhitespacePreservationEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0262cff1-a589-be03-ab85-cb1604046aa9
---

# Microsoft Edge Browser Policy Documentation DataURLWhitespacePreservationEnabled | Microsoft Learn

## DataURL Whitespace Preservation for all media types

## Supported versions

- Windows: ≥ 133
- macOS: ≥ 133
- Android: ≥ 140
- iOS: Not supported

## Description

This policy provides a temporary opt-out for changes to how Edge handles whitepsace in data URLS. Previously, whitespace would be kept only if the top level media type was text or contained the media type string xml. Now, whitespace is preserved in all data URLs, regardless of media type.

If this policy is left unset or is set to True, the new behavior is enabled.

When this policy is set to False, the old behavior is enabled.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DataURLWhitespacePreservationEnabled
- GP name: DataURL Whitespace Preservation for all media types
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Network settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DataURLWhitespacePreservationEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: DataURLWhitespacePreservationEnabled
- Example value:

```xml
<false/>
```

## Android information and settings

- Preference Key name: DataURLWhitespacePreservationEnabled
- Example value:

```
false
```