---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AuthAndroidNegotiateAccountType | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/authandroidnegotiateaccounttype
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Account type for HTTP Negotiate authentication'
locale: en-us
document_id: ffb5bffe-29fb-8a6a-651a-954e9c7a962a
document_version_independent_id: ffb5bffe-29fb-8a6a-651a-954e9c7a962a
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AuthAndroidNegotiateAccountType.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AuthAndroidNegotiateAccountType.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 152
asset_id: microsoft-edge-policies/authandroidnegotiateaccounttype
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AuthAndroidNegotiateAccountType.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: edbcae26-2c65-d921-0639-4fac6cf8a502
---

# Microsoft Edge Browser Policy Documentation AuthAndroidNegotiateAccountType | Microsoft Learn

## Account type for HTTP Negotiate authentication

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 138
- iOS: Not supported

## Description

Specifies the type of accounts provided by the Android authentication app that supports HTTP Negotiate authentication (such as Kerberos authentication). This information should be available from the supplier of the authentication app. For more information, see [Write a SPNEGO Authenticator for Microsoft Edge on Android](/en-us/DeployEdge/edge-learnmore-write-spnego-authenticator).

If you disable or don't configure this policy, HTTP Negotiate authentication on Android is turned off.

If you enable the policy, Microsoft Edge uses the value to specify the Android authentication app.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- String

## Android information and settings

- Preference Key name: AuthAndroidNegotiateAccountType
- Example value:

```
com.example.spnego
```