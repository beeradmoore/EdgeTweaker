---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BackgroundTemplateListUpdatesEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/backgroundtemplatelistupdatesenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enables background updates to the list of available templates for Collections and other features that use templates (deprecated)'
locale: en-us
document_id: 8b446fff-bbcf-27c8-670b-f9a5e52be541
document_version_independent_id: 8b446fff-bbcf-27c8-670b-f9a5e52be541
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BackgroundTemplateListUpdatesEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/BackgroundTemplateListUpdatesEnabled.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 293
asset_id: microsoft-edge-policies/backgroundtemplatelistupdatesenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BackgroundTemplateListUpdatesEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0364e358-7865-1182-03ef-3d01c5306bcd
---

# Microsoft Edge Browser Policy Documentation BackgroundTemplateListUpdatesEnabled | Microsoft Learn

## Enables background updates to the list of available templates for Collections and other features that use templates (deprecated)

> 
> DEPRECATED: This policy is deprecated. It is currently supported but will become obsolete in a future release.

## Supported versions

- Windows: ≥ 79
- macOS: ≥ 79
- Android: Not supported
- iOS: Not supported

## Description

This policy is deprecated because we are moving to a new policy. It won't work in Microsoft Edge as soon as version 104. The new policy to use is [EdgeAssetDeliveryServiceEnabled](edgeassetdeliveryserviceenabled).

Lets you enable or disable background updates to the list of available templates for Collections and other features that use templates. Templates are used to extract rich metadata from a webpage when the page is saved to a collection.

If you enable this setting or the setting is unconfigured, the list of available templates are downloaded in the background from a Microsoft service every 24 hours.

If you disable this setting the list of available templates are downloaded on demand. This type of download might result in small performance penalties for Collections and other features.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: BackgroundTemplateListUpdatesEnabled
- GP name: Enables background updates to the list of available templates for Collections and other features that use templates (deprecated)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: BackgroundTemplateListUpdatesEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: BackgroundTemplateListUpdatesEnabled
- Example value:

```xml
<true/>
```