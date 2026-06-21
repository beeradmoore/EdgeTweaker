---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AllowTokenBindingForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/allowtokenbindingforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the list of sites for which Microsoft Edge will attempt to establish a Token Binding with (obsolete)'
locale: en-us
document_id: 8b5a93fb-d97c-d312-c5cc-4dad9cda2b61
document_version_independent_id: 8b5a93fb-d97c-d312-c5cc-4dad9cda2b61
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AllowTokenBindingForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AllowTokenBindingForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 287
asset_id: microsoft-edge-policies/allowtokenbindingforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AllowTokenBindingForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b19530b3-c6e9-a5dc-c9fd-d8ff1d4cb167
---

# Microsoft Edge Browser Policy Documentation AllowTokenBindingForUrls | Microsoft Learn

## Configure the list of sites for which Microsoft Edge will attempt to establish a Token Binding with (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 129.

## Supported versions

- Windows: 83-129
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsolete because Token Binding is no longer supported, starting with Microsoft Edge 130.

Configure the list of URL patterns for sites that the browser attempts to perform the Token Binding protocol with. For the domains on this list, the browser sends the Token Binding ClientHello in the TLS handshake (See https://tools.ietf.org/html/rfc8472). If the server responds with a valid ServerHello response, the browser creates and sends Token Binding messages on subsequent https requests. See https://tools.ietf.org/html/rfc8471 for more info.

If this list is empty, Token Binding is disabled.

This policy is only available on Windows 10 devices with Virtual Secure Mode capability.

Starting in Microsoft Edge 86, this policy no longer supports dynamic refresh.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AllowTokenBindingForUrls
- GP name: Configure the list of sites for which Microsoft Edge will attempt to establish a Token Binding with (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
mydomain.com
```

```
[*.]mydomain2.com
```

```
[*.].mydomain2.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\AllowTokenBindingForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\AllowTokenBindingForUrls\1 =

```
mydomain.com
```

SOFTWARE\Policies\Microsoft\Edge\AllowTokenBindingForUrls\2 =

```
[*.]mydomain2.com
```

SOFTWARE\Policies\Microsoft\Edge\AllowTokenBindingForUrls\3 =

```
[*.].mydomain2.com
```