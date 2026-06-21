---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ProxyOverrideRules | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/proxyoverriderules
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Proxy override rules'
locale: en-us
document_id: b6d98011-9892-02eb-3b79-928e1635b3f6
document_version_independent_id: b6d98011-9892-02eb-3b79-928e1635b3f6
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ProxyOverrideRules.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ProxyOverrideRules.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 587
asset_id: microsoft-edge-policies/proxyoverriderules
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ProxyOverrideRules.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f3e8e19d-543c-a2f5-59af-f7f01ea33a25
---

# Microsoft Edge Browser Policy Documentation ProxyOverrideRules | Microsoft Learn

## Proxy override rules

## Supported versions

- Windows: ≥ 145
- macOS: ≥ 145
- Android: Not supported
- iOS: Not supported

## Description

This policy enables rule-based proxy selection that determines which proxy Microsoft Edge uses based on the destination URL and any other conditions you define.

When this policy is configured, it takes precedence over proxy settings configured by the ProxySettings policy, the Edge.proxy extension API, and any manual user settings.

If this policy is disabled or not configured, existing proxy policies and user-defined settings continue to apply.

When Edge selects a proxy, it evaluates entries in the ProxyOverrideRules policy in order. A rule is considered a match when all the following conditions are met:

- At least one URL pattern in DestinationMatchers is matched.
- No URL pattern in ExcludeDestinationMatchers is matched.
- If Conditions is specified and non-empty, all conditions are satisfied.

For a matching rule, the value specified in ProxyList is used as the proxy. If no rule matches, proxy selection falls back to the settings defined by the ProxySettings policy.

The URL patterns supported by DestinationMatchers and ExcludeDestinationMatchers are documented at [Proxy Support in Microsoft Edge](/en-us/DeployEdge/configure-microsoft-edge-proxy-support?branch=pr-en-us-6681#proxy-config-url-patterns) . Entries in ProxyList correspond to PAC-style proxy strings, such as:

- DIRECT
- PROXY host:port
- HTTPS host:port
- SOCKS4 host:port
- SOCKS5 host:port

Alternatively, URL-form proxy specifiers can be used, for example:

- http://host :port
- https://host :port
- socks4://host:port
- socks5://host:port

The first reachable proxy in the list is used. Invalid entries are ignored.

The Conditions field specifies conditions that must all be met for an override rule to be applied when selecting a proxy. If this field is not set, the rule is applied when at least one host in DestinationMatchers matches.

The DnsProbe condition checks whether the specified DNS Host can be resolved to an IP address. The host must include a hostname (for example, example.com) and can optionally include a scheme or port (for example, `https://example.com`, example.com:123, or `https://example.com:123`). When a secure scheme (for example, https) is specified, the DNS lookup may also request the HTTPS record (see RFC 9460).

If Result is set to resolved, the condition is met when resolution succeeds. If set to not\_found, the condition is met only when resolution fails.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes
- Can only be configured through cloud policy in the Edge management service: Yes

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ProxyOverrideRules
- GP name: Proxy override rules
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Proxy server
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"Conditions": [{"DnsProbe": {"Host": "corp.ads", "Result": "resolved"}}], "DestinationMatchers": ["https://some.app.com", "https://other.app.org"], "ProxyList": ["HTTPS proxy.app:443", "DIRECT"]}, {"DestinationMatchers": ["https://Contoso.com"], "ExcludeDestinationMatchers": ["https://mail.Contoso.com"], "ProxyList": ["HTTPS proxy.app:443", "DIRECT"]}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ProxyOverrideRules
- Value type: REG\_SZ

#### Example registry value

```
[{"Conditions": [{"DnsProbe": {"Host": "corp.ads", "Result": "resolved"}}], "DestinationMatchers": ["https://some.app.com", "https://other.app.org"], "ProxyList": ["HTTPS proxy.app:443", "DIRECT"]}, {"DestinationMatchers": ["https://Contoso.com"], "ExcludeDestinationMatchers": ["https://mail.Contoso.com"], "ProxyList": ["HTTPS proxy.app:443", "DIRECT"]}]
```

#### Expanded example registry value

```
[
  {
    "Conditions": [
      {
        "DnsProbe": {
          "Host": "corp.ads",
          "Result": "resolved"
        }
      }
    ],
    "DestinationMatchers": [
      "https://some.app.com",
      "https://other.app.org"
    ],
    "ProxyList": [
      "HTTPS proxy.app:443",
      "DIRECT"
    ]
  },
  {
    "DestinationMatchers": [
      "https://Contoso.com"
    ],
    "ExcludeDestinationMatchers": [
      "https://mail.Contoso.com"
    ],
    "ProxyList": [
      "HTTPS proxy.app:443",
      "DIRECT"
    ]
  }
]
```

## Mac information and settings

- Preference Key name: ProxyOverrideRules
- Example value:

```xml
<key>ProxyOverrideRules</key>
<array>
  <dict>
    <key>Conditions</key>
    <array>
      <dict>
        <key>DnsProbe</key>
        <dict>
          <key>Host</key>
          <string>corp.ads</string>
          <key>Result</key>
          <string>resolved</string>
        </dict>
      </dict>
    </array>
    <key>DestinationMatchers</key>
    <array>
      <string>https://some.app.com</string>
      <string>https://other.app.org</string>
    </array>
    <key>ProxyList</key>
    <array>
      <string>HTTPS proxy.app:443</string>
      <string>DIRECT</string>
    </array>
  </dict>
  <dict>
    <key>DestinationMatchers</key>
    <array>
      <string>https://Contoso.com</string>
    </array>
    <key>ExcludeDestinationMatchers</key>
    <array>
      <string>https://mail.Contoso.com</string>
    </array>
    <key>ProxyList</key>
    <array>
      <string>HTTPS proxy.app:443</string>
      <string>DIRECT</string>
    </array>
  </dict>
</array>
```