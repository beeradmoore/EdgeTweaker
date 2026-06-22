---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ExtensionInstallForcelist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/extensioninstallforcelist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control which extensions are installed silently'
locale: en-us
document_id: 1a024756-26b5-f42c-e1f2-f5640a2b722e
document_version_independent_id: 1a024756-26b5-f42c-e1f2-f5640a2b722e
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ExtensionInstallForcelist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/ExtensionInstallForcelist.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 490
asset_id: microsoft-edge-policies/extensioninstallforcelist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ExtensionInstallForcelist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0ace7eaf-dced-44a3-f217-ca1121efdb2c
---

# Microsoft Edge Browser Policy Documentation ExtensionInstallForcelist | Microsoft Learn

## Control which extensions are installed silently

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Set this policy to specify a list of apps and extensions that install silently, without user interaction. Users can't uninstall or turn off this setting. Permissions are granted implicitly, including the enterprise.deviceAttributes and enterprise.platformKeys extension APIs. Note: These two APIs aren't available to apps and extensions that aren't force-installed.

If you don't set this policy, no apps or extensions are autoinstalled and users can uninstall any app in Microsoft Edge.

This policy supersedes [ExtensionInstallBlocklist](extensioninstallblocklist) policy. If a previously force-installed app or extension is removed from this list, Microsoft Edge automatically uninstalls it.

For Windows instances not joined to a Microsoft Active Directory domain, forced installation is limited to apps and extensions listed in the Microsoft Edge Add-ons website.

On macOS instances, apps and extensions from outside the Microsoft Edge Add-ons website can only be force installed if the instance is managed via MDM, or joined to a domain via MCX.

The source code of any extension can be altered by users with developer tools, potentially rendering the extension unfunctional. If there's a concern, configure the [DeveloperToolsAvailability](developertoolsavailability) policy.

Each list item of the policy is a string that contains an extension ID and, optionally, and an optional "update" URL separated by a semicolon (;). The extension ID is the 32-letter string found, for example, on edge://extensions when in Developer mode. If specified, the "update" URL should point to an Update Manifest XML document ( https://go.microsoft.com/fwlink/?linkid=2095043 ). The update URL should use one of the following schemes: http, https, or file. By default, the Microsoft Edge Add-ons website's update URL is used. The "update" URL set in this policy is only used for the initial installation; subsequent updates of the extension use the update URL in the extension's manifest. The update url for subsequent updates can be overridden using the ExtensionSettings policy. See [A detailed guide to configuring extensions using the ExtensionSettings policy](/en-us/deployedge/microsoft-edge-manage-extensions-ref-guide).

Note: This policy doesn't apply to InPrivate mode. Read about hosting extensions at [Publish and update extensions in the Microsoft Edge Add-ons website](/en-us/microsoft-edge/extensions-chromium/enterprise/hosting-and-updating).

Starting in Microsoft Edge version 149, the [Microsoft365CopilotChatIconEnabled](microsoft365copilotchaticonenabled) policy controls the display of Copilot in the toolbar.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ExtensionInstallForcelist
- GP name: Control which extensions are installed silently
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Extensions
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
gbchcmhmhahfdphkhkmpfmihenigjmpp;https://edge.microsoft.com/extensionwebstorebase/v1/crx
```

```
abcdefghijklmnopabcdefghijklmnop
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallForcelist
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallForcelist\1 =

```
gbchcmhmhahfdphkhkmpfmihenigjmpp;https://edge.microsoft.com/extensionwebstorebase/v1/crx
```

SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallForcelist\2 =

```
abcdefghijklmnopabcdefghijklmnop
```

## Mac information and settings

- Preference Key name: ExtensionInstallForcelist
- Example value:

```xml
<array>
  <string>gbchcmhmhahfdphkhkmpfmihenigjmpp;https://edge.microsoft.com/extensionwebstorebase/v1/crx</string>
  <string>abcdefghijklmnopabcdefghijklmnop</string>
</array>
```