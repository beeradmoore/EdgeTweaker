---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RelatedWebsiteSetsOverrides | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/relatedwebsitesetsoverrides
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Override Related Website Sets. (deprecated)'
locale: en-us
document_id: e7773475-a60c-e810-7d8a-4c5bddac889c
document_version_independent_id: e7773475-a60c-e810-7d8a-4c5bddac889c
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RelatedWebsiteSetsOverrides.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/RelatedWebsiteSetsOverrides.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 662
asset_id: microsoft-edge-policies/relatedwebsitesetsoverrides
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RelatedWebsiteSetsOverrides.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 373a1dcd-fb0b-ebf7-a5bf-a168d746e99b
---

# Microsoft Edge Browser Policy Documentation RelatedWebsiteSetsOverrides | Microsoft Learn

## Override Related Website Sets. (deprecated)

> 
> DEPRECATED: This policy is deprecated. It is currently supported but will become obsolete in a future release.

## Supported versions

- Windows: ≥ 121
- macOS: ≥ 121
- Android: ≥ 121
- iOS: Not supported

## Description

This policy provides a way to override the list of sets Microsoft Edge uses for Related Website Sets

Each set in the browser's list of Related Website Sets must meet the requirements of a Related Website Set. A Related Website Set must contain a primary site and one or more member sites. A set can also contain a list of service sites that it owns, and a map from a site to all its ccTLD variants. For more information on how Microsoft Edge uses Related Website Sets, see https://github.com/WICG/first-party-sets.

All sites in a Related Website Set must be a registrable domain served over HTTPS. Each site in a Related Website Set must also be unique, which means a site can't be listed more than once in a Related Website Set.

When this policy is given an empty dictionary, Microsoft Edge uses the public list of Related Website Sets.

For all sites in a Related Website Set from the replacements list, if a site is also present on a Related Website Set in the browser's list, then that site will be removed from the browser's Related Website Set. After this step, the policy's Related Website Set is added to the Microsoft Edge's list of Related Website Sets.

For all sites in a Related Website Set from the additions list, if a site is also present on a Related Website Set in Microsoft Edge's list, then the browser's Related Website Set is updated so that the new Related Website Set can be added to the browser's list. After the browser's list has been updated, the policy's Related Website Set is added to the browser's list of Related Website Sets.

The browser's list of Related Website Sets requires that for all sites in its list, no site is in more than one set. This requirement is also required for both the replacements list and the additions list. Similarly, a site can't be in both the replacements list and the additions list.

Wildcards (\*) aren't supported as a policy value, or as a value within any Related Website Set in these lists.

This policy is deprecated as of Microsoft Edge version 144 with the deprecation of Related Website Sets.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: RelatedWebsiteSetsOverrides
- GP name: Override Related Website Sets. (deprecated)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Related Website Sets Settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
{"additions": [{"associatedSites": ["https://associate2.test"], "ccTLDs": {"https://associate2.test": ["https://associate2.com"]}, "primary": "https://primary2.test", "serviceSites": ["https://associate2-content.test"]}], "replacements": [{"associatedSites": ["https://associate1.test"], "ccTLDs": {"https://associate1.test": ["https://associate1.co.uk"]}, "primary": "https://primary1.test", "serviceSites": ["https://associate1-content.test"]}]}
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: RelatedWebsiteSetsOverrides
- Value type: REG\_SZ

#### Example registry value

```
{"additions": [{"associatedSites": ["https://associate2.test"], "ccTLDs": {"https://associate2.test": ["https://associate2.com"]}, "primary": "https://primary2.test", "serviceSites": ["https://associate2-content.test"]}], "replacements": [{"associatedSites": ["https://associate1.test"], "ccTLDs": {"https://associate1.test": ["https://associate1.co.uk"]}, "primary": "https://primary1.test", "serviceSites": ["https://associate1-content.test"]}]}
```

#### Expanded example registry value

```
{
  "additions": [
    {
      "associatedSites": [
        "https://associate2.test"
      ],
      "ccTLDs": {
        "https://associate2.test": [
          "https://associate2.com"
        ]
      },
      "primary": "https://primary2.test",
      "serviceSites": [
        "https://associate2-content.test"
      ]
    }
  ],
  "replacements": [
    {
      "associatedSites": [
        "https://associate1.test"
      ],
      "ccTLDs": {
        "https://associate1.test": [
          "https://associate1.co.uk"
        ]
      },
      "primary": "https://primary1.test",
      "serviceSites": [
        "https://associate1-content.test"
      ]
    }
  ]
}
```

## Mac information and settings

- Preference Key name: RelatedWebsiteSetsOverrides
- Example value:

```xml
<key>RelatedWebsiteSetsOverrides</key>
<dict>
  <key>additions</key>
  <array>
    <dict>
      <key>associatedSites</key>
      <array>
        <string>https://associate2.test</string>
      </array>
      <key>ccTLDs</key>
      <dict>
        <key>https://associate2.test</key>
        <array>
          <string>https://associate2.com</string>
        </array>
      </dict>
      <key>primary</key>
      <string>https://primary2.test</string>
      <key>serviceSites</key>
      <array>
        <string>https://associate2-content.test</string>
      </array>
    </dict>
  </array>
  <key>replacements</key>
  <array>
    <dict>
      <key>associatedSites</key>
      <array>
        <string>https://associate1.test</string>
      </array>
      <key>ccTLDs</key>
      <dict>
        <key>https://associate1.test</key>
        <array>
          <string>https://associate1.co.uk</string>
        </array>
      </dict>
      <key>primary</key>
      <string>https://primary1.test</string>
      <key>serviceSites</key>
      <array>
        <string>https://associate1-content.test</string>
      </array>
    </dict>
  </array>
</dict>
```

## Android information and settings

- Preference Key name: RelatedWebsiteSetsOverrides
- Example value:

```
{"additions": [{"associatedSites": ["https://associate2.test"], "ccTLDs": {"https://associate2.test": ["https://associate2.com"]}, "primary": "https://primary2.test", "serviceSites": ["https://associate2-content.test"]}], "replacements": [{"associatedSites": ["https://associate1.test"], "ccTLDs": {"https://associate1.test": ["https://associate1.co.uk"]}, "primary": "https://primary1.test", "serviceSites": ["https://associate1-content.test"]}]}
```