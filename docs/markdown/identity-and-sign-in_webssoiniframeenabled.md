---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebSSOInIframeEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webssoiniframeenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Web SSO for iframe requests'
locale: en-us
document_id: c1bcef8d-4faf-cacd-1b26-655c4788cccc
document_version_independent_id: c1bcef8d-4faf-cacd-1b26-655c4788cccc
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebSSOInIframeEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/WebSSOInIframeEnabled.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 126
asset_id: microsoft-edge-policies/webssoiniframeenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebSSOInIframeEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 53cc9192-0a2c-ad2d-2542-b4cceb8e3ed1
---

# Microsoft Edge Browser Policy Documentation WebSSOInIframeEnabled | Microsoft Learn

## Enable Web SSO for iframe requests

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 143
- iOS: ≥ 143

## Description

This policy controls whether Web Single Sign-On (SSO) is allowed for iframe requests in Microsoft Edge.

If you enable this policy, Web SSO is permitted in iframe requests. If you disable this policy or don't configure it, Web SSO isn't allowed in iframe requests.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Android information and settings

- Preference Key name: WebSSOInIframeEnabled
- Example value:

```
false
```

## iOS information and settings

- Preference Key name: WebSSOInIframeEnabled
- Example value:

```xml
<false/>
```