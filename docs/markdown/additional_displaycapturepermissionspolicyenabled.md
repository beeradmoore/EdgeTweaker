---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DisplayCapturePermissionsPolicyEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/displaycapturepermissionspolicyenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Specifies whether the display-capture permissions-policy is checked or skipped (obsolete)'
locale: en-us
document_id: 43f7943b-c180-71c5-2e62-d80634f4290e
document_version_independent_id: 43f7943b-c180-71c5-2e62-d80634f4290e
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DisplayCapturePermissionsPolicyEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/DisplayCapturePermissionsPolicyEnabled.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 261
asset_id: microsoft-edge-policies/displaycapturepermissionspolicyenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DisplayCapturePermissionsPolicyEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 5ca14aeb-985f-cc68-55e4-bac3b2efe417
---

# Microsoft Edge Browser Policy Documentation DisplayCapturePermissionsPolicyEnabled | Microsoft Learn

## Specifies whether the display-capture permissions-policy is checked or skipped (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 109.

## Supported versions

- Windows: 95-109
- macOS: 95-109
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsolete. The policy was a temporary workaround for non-spec-compliant enterprise applications.

This policy stopped working in Microsoft Edge version 107 and was obsoleted in Microsoft Edge 110.

The display-capture permissions-policy gates access to getDisplayMedia(), as per this spec: https://www.w3.org/TR/screen-capture/#feature-policy-integration However, if this policy is Disabled, this requirement isn't enforced, and getDisplayMedia() is allowed from contexts that would otherwise be forbidden.

If you enable or don't configure this policy, sites can only call getDisplayMedia() from contexts that are allowlisted by the display-capture permissions-policy.

If you disable this policy, sites can call getDisplayMedia() even from contexts which are not allowlisted by the display-capture permissions policy. Other restrictions may still apply.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DisplayCapturePermissionsPolicyEnabled
- GP name: Specifies whether the display-capture permissions-policy is checked or skipped (obsolete)
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
- Value name: DisplayCapturePermissionsPolicyEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: DisplayCapturePermissionsPolicyEnabled
- Example value:

```xml
<true/>
```