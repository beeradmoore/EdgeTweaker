---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SpeechRecognitionEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/speechrecognitionenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure Speech Recognition'
locale: en-us
document_id: 2528e979-b1c5-98a9-cf73-a2cf5a573455
document_version_independent_id: 2528e979-b1c5-98a9-cf73-a2cf5a573455
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SpeechRecognitionEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/SpeechRecognitionEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 202
asset_id: microsoft-edge-policies/speechrecognitionenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SpeechRecognitionEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f1ce03f8-a248-cc1f-43c4-43581dbec443
---

# Microsoft Edge Browser Policy Documentation SpeechRecognitionEnabled | Microsoft Learn

## Configure Speech Recognition

## Supported versions

- Windows: ≥ 87
- macOS: ≥ 87
- Android: Not supported
- iOS: Not supported

## Description

Set whether websites can use the W3C Web Speech API to recognize speech from the user. The Microsoft Edge implementation of the Web Speech API uses Azure Cognitive Services, so voice data leaves the machine.

If you enable or don't configure this policy, web-based applications that use the Web Speech API can use Speech Recognition.

If you disable this policy, Speech Recognition isn't available through the Web Speech API.

Read more about this feature here: SpeechRecognition API: https://go.microsoft.com/fwlink/?linkid=2143388 Cognitive Services: https://go.microsoft.com/fwlink/?linkid=2143680

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SpeechRecognitionEnabled
- GP name: Configure Speech Recognition
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: SpeechRecognitionEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: SpeechRecognitionEnabled
- Example value:

```xml
<true/>
```