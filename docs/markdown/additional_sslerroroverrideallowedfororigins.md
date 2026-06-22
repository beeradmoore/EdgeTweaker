---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SSLErrorOverrideAllowedForOrigins | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/sslerroroverrideallowedfororigins
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow users to proceed from the HTTPS warning page for specific origins'
locale: en-us
document_id: 34a0df5a-9d5b-5330-b6fe-891b73bdbc79
document_version_independent_id: 34a0df5a-9d5b-5330-b6fe-891b73bdbc79
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SSLErrorOverrideAllowedForOrigins.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/SSLErrorOverrideAllowedForOrigins.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 286
asset_id: microsoft-edge-policies/sslerroroverrideallowedfororigins
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SSLErrorOverrideAllowedForOrigins.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7f887000-ab52-ee8f-2244-75f4909d526b
---

# Microsoft Edge Browser Policy Documentation SSLErrorOverrideAllowedForOrigins | Microsoft Learn

## Allow users to proceed from the HTTPS warning page for specific origins

## Supported versions

- Windows: ≥ 90
- macOS: ≥ 90
- Android: ≥ 140
- iOS: Not supported

## Description

Microsoft Edge shows a warning page when users visit sites that have SSL errors.

If you enable or don't configure the [SSLErrorOverrideAllowed](sslerroroverrideallowed) policy, this policy does nothing.

If you disable the [SSLErrorOverrideAllowed](sslerroroverrideallowed) policy, configuring this policy lets you configure a list of origin patterns for sites where users can continue to click through SSL error pages. Users can't click through SSL error pages on origins that are not on this list.

If you don't configure this policy, the [SSLErrorOverrideAllowed](sslerroroverrideallowed) policy applies for all sites.

For detailed information about valid origin patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. \* is not an accepted value for this policy. This policy only matches based on origin, so any path or query in the URL pattern is ignored.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SSLErrorOverrideAllowedForOrigins
- GP name: Allow users to proceed from the HTTPS warning page for specific origins
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.example.com
```

```
[*.]example.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\SSLErrorOverrideAllowedForOrigins
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\SSLErrorOverrideAllowedForOrigins\1 =

```
https://www.example.com
```

SOFTWARE\Policies\Microsoft\Edge\SSLErrorOverrideAllowedForOrigins\2 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: SSLErrorOverrideAllowedForOrigins
- Example value:

```xml
<array>
  <string>https://www.example.com</string>
  <string>[*.]example.edu</string>
</array>
```

## Android information and settings

- Preference Key name: SSLErrorOverrideAllowedForOrigins
- Example value:

```
["https://www.example.com", "[*.]example.edu"]
```