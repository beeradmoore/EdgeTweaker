---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation HttpHeaderInjection | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/httpheaderinjection
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-08-11T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure HTTP Header Injection for specific URL patterns'
locale: en-us
document_id: eb152c91-a3a4-c429-b142-2fdb259aed93
document_version_independent_id: eb152c91-a3a4-c429-b142-2fdb259aed93
updated_at: 2026-08-13T17:44:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/HttpHeaderInjection.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/b914971397b969e9105b98c6e5372090311aa2cd/edgeenterprise/microsoft-edge-policies/HttpHeaderInjection.md
git_commit_id: b914971397b969e9105b98c6e5372090311aa2cd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 425
asset_id: microsoft-edge-policies/httpheaderinjection
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/HttpHeaderInjection.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ce09508c-ca5a-826a-6e51-295693894f5f
---

# Microsoft Edge Browser Policy Documentation HttpHeaderInjection | Microsoft Learn

## Configure HTTP Header Injection for specific URL patterns

## Supported versions

- Windows: ≥ 153
- macOS: ≥ 153
- Android: Not supported
- iOS: Not supported

## Description

This policy lets you define rules that inject custom HTTP headers into web requests matching specific URL patterns. Headers injected by this policy take precedence over headers already present in the request and over modifications made by users or extensions.

A common use case for this policy is enforcing tenant access controls by injecting custom headers (for example, X-Tenant-ID).

The policy accepts a list of Rules. Each Rule contains:

- patterns: A list of URL patterns to match. For information about URL pattern format, see https://go.microsoft.com/fwlink/?linkid=2095322.
- headers: A list of header objects to inject. Each object contains:
- name: The name of the header to inject.
- value: The value of the header to inject.

If multiple rules match a request, headers from all matching rules are applied. If multiple matching rules specify the same header name, the header from the most specific URL pattern is applied. If multiple matching patterns are equally specific, the header from the rule that appears last in the list is applied.

Header names must comply with RFC 2616 (https://www.rfc-editor.org/rfc/rfc2616). Header values must not contain NUL, CR, or LF characters. Individual headers can't exceed 8 KB. Invalid headers and URL patterns are ignored.

This policy supports a maximum of 500 URL patterns across all rules. Each rule can contain up to 20 headers. URL patterns and headers that exceed these limits are ignored.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: HttpHeaderInjection
- GP name: Configure HTTP Header Injection for specific URL patterns
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Network settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"headers": [{"name": "X-Tenant-ID", "value": "123456"}, {"name": "X-Custom-Header", "value": "CustomValue"}], "patterns": ["example.com", ".example.org"]}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: HttpHeaderInjection
- Value type: REG\_SZ

#### Example registry value

```
[{"headers": [{"name": "X-Tenant-ID", "value": "123456"}, {"name": "X-Custom-Header", "value": "CustomValue"}], "patterns": ["example.com", ".example.org"]}]
```

#### Expanded example registry value

```
[
  {
    "headers": [
      {
        "name": "X-Tenant-ID",
        "value": "123456"
      },
      {
        "name": "X-Custom-Header",
        "value": "CustomValue"
      }
    ],
    "patterns": [
      "example.com",
      ".example.org"
    ]
  }
]
```

## Mac information and settings

- Preference Key name: HttpHeaderInjection
- Example value:

```xml
<key>HttpHeaderInjection</key>
<array>
  <dict>
    <key>headers</key>
    <array>
      <dict>
        <key>name</key>
        <string>X-Tenant-ID</string>
        <key>value</key>
        <string>123456</string>
      </dict>
      <dict>
        <key>name</key>
        <string>X-Custom-Header</string>
        <key>value</key>
        <string>CustomValue</string>
      </dict>
    </array>
    <key>patterns</key>
    <array>
      <string>example.com</string>
      <string>.example.org</string>
    </array>
  </dict>
</array>
```