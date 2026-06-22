---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BrowserSignin | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/browsersignin
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Browser sign-in settings'
locale: en-us
document_id: d5e9b813-a4e6-387b-18d4-e99d9acfecf7
document_version_independent_id: d5e9b813-a4e6-387b-18d4-e99d9acfecf7
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BrowserSignin.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/BrowserSignin.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 433
asset_id: microsoft-edge-policies/browsersignin
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BrowserSignin.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 447f19ca-8dc1-b2ef-980f-75738cf2aed3
---

# Microsoft Edge Browser Policy Documentation BrowserSignin | Microsoft Learn

## Browser sign-in settings

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 70
- iOS: Not supported

## Description

Specify whether a user can sign into Microsoft Edge with their account and use account-related services like sync and single sign-on (SSO). To control the availability of sync, use the [SyncDisabled](syncdisabled) policy instead.

If you set this policy to 'Disable', make sure that you also set the [NonRemovableProfileEnabled](nonremovableprofileenabled) policy to disabled because [NonRemovableProfileEnabled](nonremovableprofileenabled) disables the creation of an automatically signed in browser profile. If both policies are set, Microsoft Edge uses the 'Disable browser sign-in' policy and behaves as if [NonRemovableProfileEnabled](nonremovableprofileenabled) is set to disabled.

If you set this policy to 'Enable', users can sign in to the browser. Signing in to the browser doesn't mean that sync is turned on by default; the user must separately opt in to use this feature.

If you set this policy to 'Force', users must sign in to a profile to use the browser. By default, this allows the user to choose whether they want to sync to their account, unless sync is disabled by the domain admin or with the [SyncDisabled](syncdisabled) policy. The default value of [BrowserGuestModeEnabled](browserguestmodeenabled) policy is set to false.

If you don't configure this policy, users can decide if they want to enable the browser sign-in option and use it as they see fit.

Policy options mapping:

- Disable (0) = Disable browser sign-in
- Enable (1) = Enable browser sign-in
- Force (2) = Force users to sign-in to use the browser (all profiles)

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Disable (0) = Disable browser sign-in
- Enable (1) = Enable browser sign-in
- Force (2) = Force users to sign-in to use the browser (all profiles)
    - Windows: Not supported
    - macOS: Not supported
    - Android: Not supported
    - iOS: Not supported

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

- GP unique name: BrowserSignin
- GP name: Browser sign-in settings
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Force users to sign-in to use the browser (all profiles)
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: BrowserSignin
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: BrowserSignin
- Example value:

```xml
<integer>2</integer>
```

## Android information and settings

- Preference Key name: BrowserSignin
- Example value:

```
2
```