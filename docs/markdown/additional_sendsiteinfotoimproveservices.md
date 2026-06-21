---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SendSiteInfoToImproveServices | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/sendsiteinfotoimproveservices
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Send site information to improve Microsoft services (obsolete)'
locale: en-us
document_id: ead45c62-49d8-0e2c-3262-34c4ea3e742a
document_version_independent_id: ead45c62-49d8-0e2c-3262-34c4ea3e742a
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SendSiteInfoToImproveServices.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/SendSiteInfoToImproveServices.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 346
asset_id: microsoft-edge-policies/sendsiteinfotoimproveservices
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SendSiteInfoToImproveServices.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 8ca55bc8-782b-4434-3512-79d54e2094c5
---

# Microsoft Edge Browser Policy Documentation SendSiteInfoToImproveServices | Microsoft Learn

## Send site information to improve Microsoft services (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 88.

## Supported versions

- Windows: 77-88
- macOS: 77-88
- Android: Not supported
- iOS: Not supported

## Description

This policy is no longer supported. It's replaced by [DiagnosticData](diagnosticdata) (for Windows 7, Windows 8, and macOS) and Allow Telemetry on Win 10 (https://go.microsoft.com/fwlink/?linkid=2099569).

This policy enables sending info about websites visited in Microsoft Edge to Microsoft to improve services like search.

Enable this policy to send info about websites visited in Microsoft Edge to Microsoft. Disable this policy to not send info about websites visited in Microsoft Edge to Microsoft. In both cases, users can't change or override the setting.

On Windows 10, if you don't configure this policy, Microsoft Edge defaults to the Windows diagnostic data setting. If this policy is enabled Microsoft Edge only sends info about websites visited in Microsoft Edge if the Windows Diagnostic data setting is set to Full. If this policy is disabled Microsoft Edge won't send info about websites visited. Learn more about Windows Diagnostic data settings: (https://go.microsoft.com/fwlink/?linkid=2099569).

On Windows 7, windows 8, and macOS, this policy controls sending info about websites visited. If you don't configure this policy, Microsoft Edge defaults to the user's preference.

To enable this policy, [MetricsReportingEnabled](metricsreportingenabled) must be set to Enabled. If [SendSiteInfoToImproveServices](sendsiteinfotoimproveservices) or [MetricsReportingEnabled](metricsreportingenabled) is Not Configured or Disabled, this data won't be sent to Microsoft.

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

- GP unique name: SendSiteInfoToImproveServices
- GP name: Send site information to improve Microsoft services (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: SendSiteInfoToImproveServices
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: SendSiteInfoToImproveServices
- Example value:

```xml
<false/>
```