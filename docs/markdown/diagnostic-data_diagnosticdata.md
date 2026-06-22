---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DiagnosticData | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/diagnosticdata
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Send required and optional diagnostic data about browser usage'
locale: en-us
document_id: 79d32a1b-6b31-4e96-c0d6-5fa605c428bb
document_version_independent_id: 79d32a1b-6b31-4e96-c0d6-5fa605c428bb
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DiagnosticData.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/DiagnosticData.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 443
asset_id: microsoft-edge-policies/diagnosticdata
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DiagnosticData.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/e0ffb20c-01c6-407b-a9bd-29111652a1dc
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/3904bce4-d817-48cf-85fd-b6146fca83b7
platformId: e4a4f2d2-0b63-a052-d75c-f91cef672fbc
---

# Microsoft Edge Browser Policy Documentation DiagnosticData | Microsoft Learn

## Send required and optional diagnostic data about browser usage

## Supported versions

- Windows: ≥ 122
- macOS: ≥ 86
- Android: Not supported
- iOS: Not supported

## Description

This policy controls sending required and optional diagnostic data about browser usage to Microsoft.

Required diagnostic data is collected to keep Microsoft Edge secure, up to date and performing as expected.

Optional diagnostic data includes data about how you use the browser, websites you visit, and crash reports to Microsoft for product and service improvement.

Up to Microsoft Edge version 121, this policy isn't supported on Windows 10 devices. To control this data collection on Windows 10 for 121 and previous, IT admins must use the Windows diagnostic data group policy. This policy can either be 'Allow Telemetry' or 'Allow Diagnostic Data', depending on the version of Windows. Learn more about Windows 10 diagnostic data collection: https://go.microsoft.com/fwlink/?linkid=2099569

For Microsoft Edge version 122 and later, this policy is supported on Windows 10 devices to allow controlling Microsoft Edge data collection separately from Windows 10 diagnostics data collection.

Use one of the following settings to configure this policy:

'Off' turns off required and optional diagnostic data collection. This option isn't recommended.

'RequiredData' sends required diagnostic data but turns off optional diagnostic data collection. Microsoft Edge sends required diagnostic data to keep Microsoft Edge secure, up to date and performing as expected.

'OptionalData' sends optional diagnostic data includes data about browser usage, websites that are visited, crash reports sent to Microsoft for product and service improvement.

On Windows 7/macOS, this policy controls sending required and optional data to Microsoft.

If you don't configure this policy or disable it, Microsoft Edge defaults to the user's preference.

Policy options mapping:

- Off (0) = Off (Not recommended)
- RequiredData (1) = Required data
- OptionalData (2) = Optional data

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Off (0) = Off (Not recommended)
- RequiredData (1) = Required data
- OptionalData (2) = Optional data

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DiagnosticData
- GP name: Send required and optional diagnostic data about browser usage
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Optional data
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DiagnosticData
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: DiagnosticData
- Example value:

```xml
<integer>2</integer>
```