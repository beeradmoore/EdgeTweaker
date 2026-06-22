---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RestrictSigninToPattern | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/restrictsignintopattern
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Restrict which accounts can be used to sign in to Microsoft Edge'
locale: en-us
document_id: bbb56834-5a74-a3bf-eede-4b1e8e2cb949
document_version_independent_id: bbb56834-5a74-a3bf-eede-4b1e8e2cb949
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RestrictSigninToPattern.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/RestrictSigninToPattern.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 264
asset_id: microsoft-edge-policies/restrictsignintopattern
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RestrictSigninToPattern.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ddda5928-f241-a622-7942-fdac1f2775bb
---

# Microsoft Edge Browser Policy Documentation RestrictSigninToPattern | Microsoft Learn

## Restrict which accounts can be used to sign in to Microsoft Edge

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Determines which accounts can be used to sign in to the Microsoft Edge account that's chosen during the Sync opt-in flow.

You can configure this policy to match multiple accounts using a Perl style regular expression for the pattern. If a user tries to sign in to the browser with an account whose username doesn't match this pattern, they're blocked and will get the appropriate error message. Pattern matches are case sensitive. For more information about the regular expression rules that are used, see https://go.microsoft.com/fwlink/p/?linkid=2133903.

If you don't configure this policy or leave it blank, users can use any account to sign in to Microsoft Edge.

Signed-in profiles with a username that doesn't match this pattern will be signed out after this policy is enabled.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: RestrictSigninToPattern
- GP name: Restrict which accounts can be used to sign in to Microsoft Edge
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
.*@contoso.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: RestrictSigninToPattern
- Value type: REG\_SZ

#### Example registry value

```
.*@contoso.com
```

## Mac information and settings

- Preference Key name: RestrictSigninToPattern
- Example value:

```xml
<string>.*@contoso.com</string>
```