---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation OnSecurityEventEnterpriseConnector | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/onsecurityevententerpriseconnector
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configuration policy for Microsoft Edge for Business Reporting Connectors'
locale: en-us
document_id: c3189c2b-4bd2-0904-d197-a33f494b29bb
document_version_independent_id: c3189c2b-4bd2-0904-d197-a33f494b29bb
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/OnSecurityEventEnterpriseConnector.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/OnSecurityEventEnterpriseConnector.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 356
asset_id: microsoft-edge-policies/onsecurityevententerpriseconnector
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/OnSecurityEventEnterpriseConnector.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 37466e1f-80af-93a5-3eb8-e7a2757fb804
---

# Microsoft Edge Browser Policy Documentation OnSecurityEventEnterpriseConnector | Microsoft Learn

## Configuration policy for Microsoft Edge for Business Reporting Connectors

## Supported versions

- Windows: ≥ 139
- macOS: ≥ 149
- Android: ≥ 149
- iOS: ≥ 149

## Description

Defines the Microsoft Edge for Business Reporting Connectors service settings that apply when a security event occurs in Microsoft Edge. These events include negative verdicts from Data Loss Prevention Connectors, password reuse, navigation to unsafe pages, and other security-sensitive actions.

The service\_provider field specifies the reporting service provider. The enabled\_event\_names field lists the security events enabled for that provider.

This policy requires additional setup to take effect. For configuration guidance, see https://go.microsoft.com/fwlink/?linkid=2325446.

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

- GP unique name: OnSecurityEventEnterpriseConnector
- GP name: Configuration policy for Microsoft Edge for Business Reporting Connectors
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"enabled_event_names": ["passwordChangedEvent", "sensitiveDataEvent"], "enabled_opt_in_events": [{"name": "loginEvent", "url_patterns": ["*"]}, {"name": "passwordBreachEvent", "url_patterns": ["example.com", "other.example.com"]}], "service_provider": "microsoft"}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: OnSecurityEventEnterpriseConnector
- Value type: REG\_SZ

#### Example registry value

```
[{"enabled_event_names": ["passwordChangedEvent", "sensitiveDataEvent"], "enabled_opt_in_events": [{"name": "loginEvent", "url_patterns": ["*"]}, {"name": "passwordBreachEvent", "url_patterns": ["example.com", "other.example.com"]}], "service_provider": "microsoft"}]
```

#### Expanded example registry value

```
[
  {
    "enabled_event_names": [
      "passwordChangedEvent",
      "sensitiveDataEvent"
    ],
    "enabled_opt_in_events": [
      {
        "name": "loginEvent",
        "url_patterns": [
          "*"
        ]
      },
      {
        "name": "passwordBreachEvent",
        "url_patterns": [
          "example.com",
          "other.example.com"
        ]
      }
    ],
    "service_provider": "microsoft"
  }
]
```

## Mac information and settings

- Preference Key name: OnSecurityEventEnterpriseConnector
- Example value:

```xml
<key>OnSecurityEventEnterpriseConnector</key>
<array>
  <dict>
    <key>enabled_event_names</key>
    <array>
      <string>passwordChangedEvent</string>
      <string>sensitiveDataEvent</string>
    </array>
    <key>enabled_opt_in_events</key>
    <array>
      <dict>
        <key>name</key>
        <string>loginEvent</string>
        <key>url_patterns</key>
        <array>
          <string>*</string>
        </array>
      </dict>
      <dict>
        <key>name</key>
        <string>passwordBreachEvent</string>
        <key>url_patterns</key>
        <array>
          <string>example.com</string>
          <string>other.example.com</string>
        </array>
      </dict>
    </array>
    <key>service_provider</key>
    <string>microsoft</string>
  </dict>
</array>
```

## Android information and settings

- Preference Key name: OnSecurityEventEnterpriseConnector
- Example value:

```
[{"enabled_event_names": ["passwordChangedEvent", "sensitiveDataEvent"], "enabled_opt_in_events": [{"name": "loginEvent", "url_patterns": ["*"]}, {"name": "passwordBreachEvent", "url_patterns": ["example.com", "other.example.com"]}], "service_provider": "microsoft"}]
```

## iOS information and settings

- Preference Key name: OnSecurityEventEnterpriseConnector
- Example value:

```xml
<key>OnSecurityEventEnterpriseConnector</key>
<array>
  <dict>
    <key>enabled_event_names</key>
    <array>
      <string>passwordChangedEvent</string>
      <string>sensitiveDataEvent</string>
    </array>
    <key>enabled_opt_in_events</key>
    <array>
      <dict>
        <key>name</key>
        <string>loginEvent</string>
        <key>url_patterns</key>
        <array>
          <string>*</string>
        </array>
      </dict>
      <dict>
        <key>name</key>
        <string>passwordBreachEvent</string>
        <key>url_patterns</key>
        <array>
          <string>example.com</string>
          <string>other.example.com</string>
        </array>
      </dict>
    </array>
    <key>service_provider</key>
    <string>microsoft</string>
  </dict>
</array>
```