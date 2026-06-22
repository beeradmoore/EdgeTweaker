---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation MetricsReportingEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/metricsreportingenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable usage and crash-related data reporting (obsolete)'
locale: en-us
document_id: ddefc427-d808-76fc-1fd0-2db8be741872
document_version_independent_id: ddefc427-d808-76fc-1fd0-2db8be741872
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/MetricsReportingEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/MetricsReportingEnabled.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 384
asset_id: microsoft-edge-policies/metricsreportingenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/MetricsReportingEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: a7baacd3-d435-96ed-e771-346d00844643
---

# Microsoft Edge Browser Policy Documentation MetricsReportingEnabled | Microsoft Learn

## Enable usage and crash-related data reporting (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 88.

## Supported versions

- Windows: 77-88
- macOS: 77-88
- Android: Not supported
- iOS: Not supported

## Description

This policy is no longer supported. It's replaced by [DiagnosticData](diagnosticdata) (for Windows 7, Windows 8, and macOS) and Allow Telemetry on Win 10 (https://go.microsoft.com/fwlink/?linkid=2099569).

This policy enables reporting of usage and crash-related data about Microsoft Edge to Microsoft.

Enable this policy to send reporting of usage and crash-related data to Microsoft. Disable this policy to not send the data to Microsoft. In both cases, users can't change or override the setting.

On Windows 10, if you don't configure this policy, Microsoft Edge defaults to the Windows diagnostic data setting. If you enable this policy, Microsoft Edge only sends usage data if the Windows Diagnostic data setting is set to Enhanced or Full. If you disable this policy, Microsoft Edge won't send usage data. Crash-related data is sent based on the Windows Diagnostic data setting. Learn more about Windows Diagnostic data settings at https://go.microsoft.com/fwlink/?linkid=2099569

On Windows 7, Windows 8, and macOS, this policy controls sending usage and crash-related data. If you don't configure this policy, Microsoft Edge defaults to the user's preference.

To enable this policy,[SendSiteInfoToImproveServices](sendsiteinfotoimproveservices) must be set to Enabled. If [MetricsReportingEnabled](metricsreportingenabled) or [SendSiteInfoToImproveServices](sendsiteinfotoimproveservices) is Not Configured or Disabled, this data won't be sent to Microsoft.

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, Windows 10 Pro or Enterprise instances that enrolled for device management, or macOS instances that are managed via MDM or joined to a domain via MCX.

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

- GP unique name: MetricsReportingEnabled
- GP name: Enable usage and crash-related data reporting (obsolete)
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
- Value name: MetricsReportingEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: MetricsReportingEnabled
- Example value:

```xml
<true/>
```