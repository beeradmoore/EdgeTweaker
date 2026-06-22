---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ProxySettings | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/proxysettings
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Proxy settings'
locale: en-us
document_id: 84dee280-6604-8e0f-841a-20c80173605b
document_version_independent_id: 84dee280-6604-8e0f-841a-20c80173605b
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ProxySettings.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/ProxySettings.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 384
asset_id: microsoft-edge-policies/proxysettings
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ProxySettings.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 885ef0b5-192f-72dd-843a-5c145a4e16d1
---

# Microsoft Edge Browser Policy Documentation ProxySettings | Microsoft Learn

## Proxy settings

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: Not supported

## Description

Configures the proxy settings for Microsoft Edge.

If you enable this policy, Microsoft Edge ignores all proxy-related options specified from the command line.

If you don't configure this policy, users can choose their own proxy settings.

This policy overrides the following individual policies:

[ProxyMode](proxymode)

[ProxyPacUrl](proxypacurl)

[ProxyServer](proxyserver)

[ProxyBypassList](proxybypasslist)

Setting the [ProxySettings](proxysettings) policy accepts the following fields:

- ProxyMode, which lets you specify the proxy server used by Microsoft Edge and prevents users from changing proxy settings
- ProxyPacUrl, a URL to a proxy .pac file or a PAC script encoded as a data URL with MIME type application/x-ns-proxy-autoconfig
- ProxyPacMandatory, a boolean flag that prevents the network stack from falling back to direct connections with invalid or unavailable PAC script
- ProxyServer, a URL for the proxy server
- ProxyBypassList, a list of proxy hosts that Microsoft Edge bypasses

For ProxyMode, the following values when chosen lead to the following results:

- direct, a proxy is never used and all other fields are ignored.
- system, the systems's proxy is used and all other fields are ignored.
- auto\_detect, all other fields are ignored.
- fixed\_servers, the ProxyServer and ProxyBypassList fields are used.
- pac\_script, the ProxyPacUrl, ProxyPacMandatory and ProxyBypassList fields are used.

For more detailed examples, see https://go.microsoft.com/fwlink/?linkid=2094936.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ProxySettings
- GP name: Proxy settings
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Proxy server
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
{"ProxyBypassList": "https://www.example1.com,https://www.example2.com,https://internalsite/", "ProxyMode": "pac_script", "ProxyPacMandatory": false, "ProxyPacUrl": "https://internal.site/example.pac", "ProxyServer": "123.123.123.123:8080"}
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ProxySettings
- Value type: REG\_SZ

#### Example registry value

```
{"ProxyBypassList": "https://www.example1.com,https://www.example2.com,https://internalsite/", "ProxyMode": "pac_script", "ProxyPacMandatory": false, "ProxyPacUrl": "https://internal.site/example.pac", "ProxyServer": "123.123.123.123:8080"}
```

#### Expanded example registry value

```
{
  "ProxyBypassList": "https://www.example1.com,https://www.example2.com,https://internalsite/",
  "ProxyMode": "pac_script",
  "ProxyPacMandatory": false,
  "ProxyPacUrl": "https://internal.site/example.pac",
  "ProxyServer": "123.123.123.123:8080"
}
```

## Mac information and settings

- Preference Key name: ProxySettings
- Example value:

```xml
<key>ProxySettings</key>
<dict>
  <key>ProxyBypassList</key>
  <string>https://www.example1.com,https://www.example2.com,https://internalsite/</string>
  <key>ProxyMode</key>
  <string>pac_script</string>
  <key>ProxyPacMandatory</key>
  <false/>
  <key>ProxyPacUrl</key>
  <string>https://internal.site/example.pac</string>
  <key>ProxyServer</key>
  <string>123.123.123.123:8080</string>
</dict>
```

## Android information and settings

- Preference Key name: ProxySettings
- Example value:

```
{"ProxyBypassList": "https://www.example1.com,https://www.example2.com,https://internalsite/", "ProxyMode": "pac_script", "ProxyPacMandatory": false, "ProxyPacUrl": "https://internal.site/example.pac", "ProxyServer": "123.123.123.123:8080"}
```