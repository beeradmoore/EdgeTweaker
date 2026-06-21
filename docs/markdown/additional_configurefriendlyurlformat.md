---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ConfigureFriendlyURLFormat | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/configurefriendlyurlformat
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the default paste format of URLs copied from Microsoft Edge, and determine if additional formats will be available to users'
locale: en-us
document_id: 761e1947-14cf-caa5-b52d-8f180f467fb6
document_version_independent_id: 761e1947-14cf-caa5-b52d-8f180f467fb6
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ConfigureFriendlyURLFormat.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ConfigureFriendlyURLFormat.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 591
asset_id: microsoft-edge-policies/configurefriendlyurlformat
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ConfigureFriendlyURLFormat.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 32d07985-cce0-6eb1-f33b-ed9dd89c4a02
---

# Microsoft Edge Browser Policy Documentation ConfigureFriendlyURLFormat | Microsoft Learn

## Configure the default paste format of URLs copied from Microsoft Edge, and determine if additional formats will be available to users

## Supported versions

- Windows: ≥ 87
- macOS: ≥ 88
- Android: Not supported
- iOS: Not supported

## Description

If FriendlyURLs are enabled, Microsoft Edge computes more representations of the URL and places them on the clipboard.

This policy configures what format is pasted when the user pastes in external applications or inside Microsoft Edge without the 'Paste as' context menu item.

If you configure this policy, it makes a choice on behalf of the user. The options in edge://settings/shareCopyPaste will be grayed out, and the options in the 'Paste As' context menu won't be available.

- Not configured = The users are able to choose their preferred paste format. By default, this is set to the friendly URL format. The 'Paste As' menu will be available in Microsoft Edge.
- 1 = No additional formats are stored on the clipboard. There will be no 'Paste as' context menu item in Microsoft Edge, and the only format available to paste will be the plain text URL format. Effectively, the friendly URL feature is disabled.
- 3 = The user gets a friendly URL whenever they paste into surfaces that accept rich text. The plain URL is still available for nonrich surfaces. There will be no 'Paste As' menu in Microsoft Edge.
- 4 = (Not currently used)

The richer formats may not be supported in some paste destinations and/or websites. In these scenarios, the plain URL option is recommended when configuring this policy.

The recommended policy is available in Microsoft Edge 105 or later.

Policy options mapping:

- PlainText (1) = The plain URL without any extra information, such as the page's title. This is the recommended option when this policy is configured. For more information, see the description.
- TitledHyperlink (3) = Titled Hyperlink: A hyperlink that points to the copied URL but whose visible text is the title of the destination page. This is the Friendly URL format.
- WebPreview (4) = Coming soon. If set, behaves the same as 'Plain URL'.

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- PlainText (1) = The plain URL without any extra information, such as the page's title. This is the recommended option when this policy is configured. For more information, see the description.
- TitledHyperlink (3) = Titled Hyperlink: A hyperlink that points to the copied URL but whose visible text is the title of the destination page. This is the Friendly URL format.
- WebPreview (4) = Coming soon. If set, behaves the same as 'Plain URL'.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ConfigureFriendlyURLFormat
- GP name: Configure the default paste format of URLs copied from Microsoft Edge, and determine if additional formats will be available to users
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Titled Hyperlink: A hyperlink that points to the copied URL but whose visible text is the title of the destination page. This is the Friendly URL format.
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: ConfigureFriendlyURLFormat
- Value type: REG\_DWORD

#### Example registry value

```
0x00000003
```

## Mac information and settings

- Preference Key name: ConfigureFriendlyURLFormat
- Example value:

```xml
<integer>3</integer>
```