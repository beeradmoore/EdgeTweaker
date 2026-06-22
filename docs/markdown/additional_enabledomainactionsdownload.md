---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EnableDomainActionsDownload | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/enabledomainactionsdownload
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Domain Actions Download from Microsoft (obsolete)'
locale: en-us
document_id: 2ad10278-4d30-958c-d010-0bce9d0950b9
document_version_independent_id: 2ad10278-4d30-958c-d010-0bce9d0950b9
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EnableDomainActionsDownload.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/EnableDomainActionsDownload.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 394
asset_id: microsoft-edge-policies/enabledomainactionsdownload
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EnableDomainActionsDownload.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: df2de314-0667-39af-c2e0-b0da5ffc91c1
---

# Microsoft Edge Browser Policy Documentation EnableDomainActionsDownload | Microsoft Learn

## Enable Domain Actions Download from Microsoft (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 84.

## Supported versions

- Windows: 77-84
- macOS: 77-84
- Android: Not supported
- iOS: Not supported

## Description

This policy doesn't work because conflicting states should be avoided. This policy was used to enable/disable download of the domain actions list, but it didn't always achieve the desired state. The Experimentation and Configuration Service, which handles the download, has its own policy to configure what's downloaded from the service. Use the [ExperimentationAndConfigurationServiceControl](experimentationandconfigurationservicecontrol) policy instead.

In Microsoft Edge, Domain Actions represent a series of compatibility features that help the browser work correctly on the web.

Microsoft keeps a list of actions to take on certain domains for compatibility reasons. For example, the browser may override the User Agent string on a website if that website is broken due to the new User Agent string on Microsoft Edge. Each of these actions is intended to be temporary while Microsoft tries to resolve the issue with the site owner.

When the browser starts up and then periodically afterwards, the browser will contact the Experimentation and Configuration Service that contains the most up to date list of compatibility actions to perform. This list is saved locally after it's first retrieved so that subsequent requests will only update the list if the server's copy has changed.

If you enable this policy, the list of Domain Actions continues to be downloaded from the Experimentation and Configuration Service.

If you disable this policy, the list of Domain Actions will no longer be downloaded from the Experimentation and Configuration Service.

If you don't configure this policy, the list of Domain Actions continues to be downloaded from the Experimentation and Configuration Service.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: EnableDomainActionsDownload
- GP name: Enable Domain Actions Download from Microsoft (obsolete)
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
- Value name: EnableDomainActionsDownload
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: EnableDomainActionsDownload
- Example value:

```xml
<true/>
```