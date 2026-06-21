---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeDefaultProfileEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgedefaultprofileenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default Profile Setting Enabled'
locale: en-us
document_id: 9d48aeb9-ef1f-492e-3069-7e5d874bf2c3
document_version_independent_id: 9d48aeb9-ef1f-492e-3069-7e5d874bf2c3
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeDefaultProfileEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EdgeDefaultProfileEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 359
asset_id: microsoft-edge-policies/edgedefaultprofileenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeDefaultProfileEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 3bc1406b-97dd-b953-24a4-d55df533d993
---

# Microsoft Edge Browser Policy Documentation EdgeDefaultProfileEnabled | Microsoft Learn

## Default Profile Setting Enabled

## Supported versions

- Windows: ≥ 101
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Configuring this policy lets you set a default profile in Microsoft Edge to be used when opening the browser rather than the last profile used. This policy doesn't affect when "--profile-directory" parameter is specified. Set the value to "Default" to refer to the default profile. The value is case sensitive. The value of the policy is the name of the profile (case sensitive) and can be configured with string that is the name of a specific profile. The value "Edge Kids Mode" and "Guest Profile" are considered not useful values because they not supposed to be a default profile. This policy doesn't impact the following scenarios:

1. Settings specified in "Profile preferences for sites" in "Profile preferences"
2. Links opening from Outlook and Teams.

The following statements are under the condition of not specify the "--profile-directory" and configured value isn't "Edge Kids Mode" or "Guest Profile": If you enable this policy and configure it with a specific profile name and the specified profile can be found, Microsoft Edge will use the specified profile when launching and the setting of "Default profile for external link" is changed to the specified profile name and greyed out. If you enable this policy and configure it with a specific profile name but it can't be found, the policy will behave like it's never been set before. If you enable this policy, but don't configure or disable it, the policy will behave like it's never been set before.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: EdgeDefaultProfileEnabled
- GP name: Default Profile Setting Enabled
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Identity and sign-in
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Default
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: EdgeDefaultProfileEnabled
- Value type: REG\_SZ

#### Example registry value

```
Default
```