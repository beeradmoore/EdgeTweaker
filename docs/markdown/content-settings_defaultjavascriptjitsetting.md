---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultJavaScriptJitSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultjavascriptjitsetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control use of JavaScript JIT'
locale: en-us
document_id: b959dc55-c54a-45b7-b869-006db0c8c813
document_version_independent_id: b959dc55-c54a-45b7-b869-006db0c8c813
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultJavaScriptJitSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/DefaultJavaScriptJitSetting.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 294
asset_id: microsoft-edge-policies/defaultjavascriptjitsetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultJavaScriptJitSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 972aa87c-4394-3fdb-c462-c2e1caa8f787
---

# Microsoft Edge Browser Policy Documentation DefaultJavaScriptJitSetting | Microsoft Learn

## Control use of JavaScript JIT

## Supported versions

- Windows: ≥ 93
- macOS: ≥ 93
- Android: ≥ 138
- iOS: Not supported

## Description

Allows you to set whether Microsoft Edge runs the v8 JavaScript engine with JIT (Just In Time) compiler enabled or not.

Disabling the JavaScript JIT means that Microsoft Edge can render web content more slowly, and can also disable parts of JavaScript including WebAssembly. Disabling the JavaScript JIT can allow Microsoft Edge to render web content in a more secure configuration.

This policy can be overridden for specific URL patterns using the [JavaScriptJitAllowedForSites](javascriptjitallowedforsites) and [JavaScriptJitBlockedForSites](javascriptjitblockedforsites) policies.

If you don't configure this policy, JavaScript JIT is enabled.

Policy options mapping:

- AllowJavaScriptJit (1) = Allow any site to run JavaScript JIT
- BlockJavaScriptJit (2) = Do not allow any site to run JavaScript JIT

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- AllowJavaScriptJit (1) = Allow any site to run JavaScript JIT
- BlockJavaScriptJit (2) = Do not allow any site to run JavaScript JIT

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DefaultJavaScriptJitSetting
- GP name: Control use of JavaScript JIT
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Allow any site to run JavaScript JIT
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultJavaScriptJitSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: DefaultJavaScriptJitSetting
- Example value:

```xml
<integer>1</integer>
```

## Android information and settings

- Preference Key name: DefaultJavaScriptJitSetting
- Example value:

```
1
```