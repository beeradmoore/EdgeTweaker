---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation OnBulkDataEntryEnterpriseConnector | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/onbulkdataentryenterpriseconnector
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configuration policy for bulk data entry for Microsoft Edge for Business Data Loss Prevention Connectors'
locale: en-us
document_id: 57ba77ae-ec2c-0cc3-d155-19739aff289d
document_version_independent_id: 57ba77ae-ec2c-0cc3-d155-19739aff289d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/OnBulkDataEntryEnterpriseConnector.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/OnBulkDataEntryEnterpriseConnector.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 432
asset_id: microsoft-edge-policies/onbulkdataentryenterpriseconnector
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/OnBulkDataEntryEnterpriseConnector.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9ef231d7-5d52-dae2-b81e-7af31516ce29
---

# Microsoft Edge Browser Policy Documentation OnBulkDataEntryEnterpriseConnector | Microsoft Learn

## Configuration policy for bulk data entry for Microsoft Edge for Business Data Loss Prevention Connectors

## Supported versions

- Windows: ≥ 137
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

List of Microsoft Edge for Business Data Loss Prevention Connectors services settings to be applied when data is entered in Microsoft Edge from the clipboard or by drag and dropping web content.

Connector Fields

1. url\_list, tags, enable, disable These fields determine whether the connector sends data for analysis when content is entered on a specific page, and which tags to include in the analysis request. A tag associated with an enable pattern is included in the request if the page URL matches the pattern—unless a corresponding disable pattern also matches. Analysis is triggered if at least one tag is included in the request.
2. service\_provider Identifies the analysis service provider the configuration applies to.
3. block\_until\_verdict If set to 1, Microsoft Edge waits for a response from the analysis service before giving the page access to the data. Any other integer value allows the page to access the data immediately.
4. default\_action If set to block, Microsoft Edge denies page access to the data if an error occurs while contacting the analysis service. Any other value permits the page to access the data.
5. minimum\_data\_size Specifies the minimum size (in bytes) that the entered data must meet or exceed to be scanned. Default: 100 bytes if the field isn't set.

This policy requires further setup to take effect. For configuration guidance, see https://go.microsoft.com/fwlink/?linkid=2320413.

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

- GP unique name: OnBulkDataEntryEnterpriseConnector
- GP name: Configuration policy for bulk data entry for Microsoft Edge for Business Data Loss Prevention Connectors
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"block_until_verdict": 0, "default_action": "allow", "disable": [{"tags": ["malware"], "url_list": ["*.us.com"]}], "enable": [{"tags": ["malware"], "url_list": ["*"]}, {"tags": ["dlp"], "url_list": ["*.them.com", "*.others.com"]}], "minimum_data_size": 100, "service_provider": "local_system_agent"}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: OnBulkDataEntryEnterpriseConnector
- Value type: REG\_SZ

#### Example registry value

```
[{"block_until_verdict": 0, "default_action": "allow", "disable": [{"tags": ["malware"], "url_list": ["*.us.com"]}], "enable": [{"tags": ["malware"], "url_list": ["*"]}, {"tags": ["dlp"], "url_list": ["*.them.com", "*.others.com"]}], "minimum_data_size": 100, "service_provider": "local_system_agent"}]
```

#### Expanded example registry value

```
[
  {
    "block_until_verdict": 0,
    "default_action": "allow",
    "disable": [
      {
        "tags": [
          "malware"
        ],
        "url_list": [
          "*.us.com"
        ]
      }
    ],
    "enable": [
      {
        "tags": [
          "malware"
        ],
        "url_list": [
          "*"
        ]
      },
      {
        "tags": [
          "dlp"
        ],
        "url_list": [
          "*.them.com",
          "*.others.com"
        ]
      }
    ],
    "minimum_data_size": 100,
    "service_provider": "local_system_agent"
  }
]
```