---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebContentFilteringBlockedCategories | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webcontentfilteringblockedcategories
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure Web Content Filtering'
locale: en-us
document_id: 481e47d1-18d8-ff84-9931-78925b855c92
document_version_independent_id: 481e47d1-18d8-ff84-9931-78925b855c92
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebContentFilteringBlockedCategories.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WebContentFilteringBlockedCategories.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 597
asset_id: microsoft-edge-policies/webcontentfilteringblockedcategories
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebContentFilteringBlockedCategories.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ab043f50-9a20-c1db-2f01-50e5becdd595
---

# Microsoft Edge Browser Policy Documentation WebContentFilteringBlockedCategories | Microsoft Learn

## Configure Web Content Filtering

## Supported versions

- Windows: ≥ 135
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Configure this policy to block access to specific categories of websites in Microsoft Edge on Windows devices. Web Content Filtering is available exclusively in Microsoft Edge on Windows and requires the appropriate Microsoft 365 licensing.

When this policy is enabled, users are blocked from accessing URLs that fall within the defined list of content categories. You can configure this by adding Category Strings to the list of blocked categories.

If the policy is not configured or is disabled, no categories will be blocked.

To view the list of supported content categories, including each Category String and its definition, refer to: [Web content filtering](/en-us/defender-endpoint/web-content-filtering?view=o365-worldwide#category-definitions)

To block a specific URL outside of a category, use the “Block access to a list of URLs” policy.

To allow a specific URL that falls under a blocked category, use the “Define a list of allowed URLs” policy.

Note: This policy is supported only when deployed through the Edge management service, not via Microsoft Intune.

To use this policy, your organization must have one of the following licenses:

- Microsoft 365 A1, A3, or A5
- Microsoft 365 Business Premium
- Microsoft 365 Business Basic or Standard with Intune Plan 1 or Plan 2

Policy options mapping:

- chat (chat) = Chat
- child\_abuse\_images (child\_abuse\_images) = Child Abuse Images
- criminal\_activity (criminal\_activity) = Criminal Activity
- download\_sites (download\_sites) = Download Sites
- gambling (gambling) = Gambling
- games (games) = Games
- hacking (hacking) = Hacking
- hate\_and\_intolerance (hate\_and\_intolerance) = Hate and Intolerance
- illegal\_drug (illegal\_drug) = Illegal Drug
- illegal\_software (illegal\_software) = Illegal Software
- image\_sharing (image\_sharing) = Image Sharing
- instant\_messaging (instant\_messaging) = Instant Messaging
- nudity (nudity) = Nudity
- peer\_to\_peer (peer\_to\_peer) = Peer to Peer
- pornography\_or\_sexually\_explicit (pornography\_or\_sexually\_explicit) = Pornography or Sexually Explicit
- professional\_networking (professional\_networking) = Professional Networking
- self\_harm (self\_harm) = Self Harm
- sex\_education (sex\_education) = Sex Education
- social\_networking (social\_networking) = Social Networking
- streaming\_and\_downloads (streaming\_and\_downloads) = Streaming Media and Downloads
- tasteless (tasteless) = Tasteless
- violence (violence) = Violence
- weapons (weapons) = Weapons
- web\_based\_email (web\_based\_email) = Web Based Email
- gen\_ai (gen\_ai) = Gen AI
- shopping (shopping) = Shopping
- 3p\_search\_engines (3p\_search\_engines) = 3P Search Engines
- none (none) = None

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- chat = Chat
- child\_abuse\_images = Child Abuse Images
- criminal\_activity = Criminal Activity
- download\_sites = Download Sites
- gambling = Gambling
- games = Games
- hacking = Hacking
- hate\_and\_intolerance = Hate and Intolerance
- illegal\_drug = Illegal Drug
- illegal\_software = Illegal Software
- image\_sharing = Image Sharing
- instant\_messaging = Instant Messaging
- nudity = Nudity
- peer\_to\_peer = Peer to Peer
- pornography\_or\_sexually\_explicit = Pornography or Sexually Explicit
- professional\_networking = Professional Networking
- self\_harm = Self Harm
- sex\_education = Sex Education
- social\_networking = Social Networking
- streaming\_and\_downloads = Streaming Media and Downloads
- tasteless = Tasteless
- violence = Violence
- weapons = Weapons
- web\_based\_email = Web Based Email
- gen\_ai = Gen AI
- shopping = Shopping
- 3p\_search\_engines = 3P Search Engines
- none = None

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: WebContentFilteringBlockedCategories
- GP name: Configure Web Content Filtering
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Gambling
```

```
Streaming Media and Downloads
```

```
Games
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\WebContentFilteringBlockedCategories
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\WebContentFilteringBlockedCategories\1 =

```
gambling
```

SOFTWARE\Policies\Microsoft\Edge\WebContentFilteringBlockedCategories\2 =

```
streaming_and_downloads
```

SOFTWARE\Policies\Microsoft\Edge\WebContentFilteringBlockedCategories\3 =

```
games
```