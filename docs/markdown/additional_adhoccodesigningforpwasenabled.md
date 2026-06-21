---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AdHocCodeSigningForPWAsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/adhoccodesigningforpwasenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Native application signing during Progressive Web Application installation'
locale: en-us
document_id: bf1da4f2-d453-b058-ccd3-7b8cf9e2c484
document_version_independent_id: bf1da4f2-d453-b058-ccd3-7b8cf9e2c484
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AdHocCodeSigningForPWAsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AdHocCodeSigningForPWAsEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 160
asset_id: microsoft-edge-policies/adhoccodesigningforpwasenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AdHocCodeSigningForPWAsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 8166b4cd-29e7-8743-1d30-c36e146b7399
---

# Microsoft Edge Browser Policy Documentation AdHocCodeSigningForPWAsEnabled | Microsoft Learn

## Native application signing during Progressive Web Application installation

## Supported versions

- Windows: Not supported
- macOS: ≥ 132
- Android: Not supported
- iOS: Not supported

## Description

Enabling this policy or leaving it unset enables the use of ad-hoc signatures for the native application that's created when installing a Progressive Web Application (PWA). This ensures that each installed application has a unique identity to macOS system components.

Disabling this policy results in every native application created when installing Progressive Web Applications having the same identity. This can interfere with macOS functionality.

Turn off the policy only if you're using an endpoint security solution that blocks applications with an ad-hoc signature.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Mac information and settings

- Preference Key name: AdHocCodeSigningForPWAsEnabled
- Example value:

```xml
<false/>
```