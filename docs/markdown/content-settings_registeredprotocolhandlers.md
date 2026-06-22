---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RegisteredProtocolHandlers | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/registeredprotocolhandlers
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Register protocol handlers'
locale: en-us
document_id: ad524209-f07d-1248-4e6f-f81a96bb6afe
document_version_independent_id: ad524209-f07d-1248-4e6f-f81a96bb6afe
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RegisteredProtocolHandlers.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/RegisteredProtocolHandlers.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 305
asset_id: microsoft-edge-policies/registeredprotocolhandlers
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RegisteredProtocolHandlers.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 55b51d21-0f91-6aec-2cdd-0f3e97e9d3f0
---

# Microsoft Edge Browser Policy Documentation RegisteredProtocolHandlers | Microsoft Learn

## Register protocol handlers

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Set this policy (recommended only) to register a list of protocol handlers. This list is merged with ones registered by the user and both are available to use.

To register a protocol handler:

- Set the protocol property to the scheme (for example, "mailto")
- Set the URL property to the URL property of the application that handlers the scheme specified in the "protocol" field. The pattern can include a "%s" placeholder, which the handled URL replaces.

Users can't remove a protocol handler registered by this policy. However, they can install a new default protocol handler to override the existing protocol handlers.

In the examples in this section, the URL points to the Outlook on the Web (OWA) endpoint used in Exchange Online. If you're targeting Exchange Server (on-premises), use the following URL and replace mail.contoso.com with your organization's OWA endpoint:

`https://mail.contoso.com/?path=/mail/action/compose`&mailtouri=%s

## Supported features

- Can be mandatory: No
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: RegisteredProtocolHandlers
- GP name: Register protocol handlers
- GP path (Mandatory): N/A
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Content settings
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"default": true, "protocol": "mailto", "url": "https://outlook.office.com/mail/deeplink/compose?to=%s"}]
```

### Registry settings

- Path (Mandatory): N/A
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: RegisteredProtocolHandlers
- Value type: REG\_SZ

#### Example registry value

```
[{"default": true, "protocol": "mailto", "url": "https://outlook.office.com/mail/deeplink/compose?to=%s"}]
```

#### Expanded example registry value

```
[
  {
    "default": true,
    "protocol": "mailto",
    "url": "https://outlook.office.com/mail/deeplink/compose?to=%s"
  }
]
```

## Mac information and settings

- Preference Key name: RegisteredProtocolHandlers
- Example value:

```xml
<key>RegisteredProtocolHandlers</key>
<array>
  <dict>
    <key>default</key>
    <true/>
    <key>protocol</key>
    <string>mailto</string>
    <key>url</key>
    <string>https://outlook.office.com/mail/deeplink/compose?to=%s</string>
  </dict>
</array>
```