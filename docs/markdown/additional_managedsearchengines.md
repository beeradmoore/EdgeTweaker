---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ManagedSearchEngines | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/managedsearchengines
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Manage Search Engines'
locale: en-us
document_id: 471c4bb2-4730-acf8-6da3-7205655bf6fc
document_version_independent_id: 471c4bb2-4730-acf8-6da3-7205655bf6fc
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ManagedSearchEngines.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/ManagedSearchEngines.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 556
asset_id: microsoft-edge-policies/managedsearchengines
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ManagedSearchEngines.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 4e34fbd9-b0cd-766f-a94e-9e82b97ad80a
---

# Microsoft Edge Browser Policy Documentation ManagedSearchEngines | Microsoft Learn

## Manage Search Engines

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Lets you configure a list of up to 10 search engines, one of which must be marked as the default search engine. With Microsoft Edge version 100, you can configure up to 100 engines.

You don't need to specify the encoding. With Microsoft Edge version 80, the suggest\_url and image\_search\_url parameters are optional. The optional parameter, image\_search\_post\_params (consists of comma-separated name/value pairs), is available starting in Microsoft Edge version 80.

With Microsoft Edge version 83, you can enable search engine discovery with the optional allow\_search\_engine\_discovery parameter. This parameter must be the first item in the list. If allow\_search\_engine\_discovery isn't specified, search engine discovery is disabled by default. With Microsoft Edge version 84, you can set this policy as a recommended policy to allow search provider discovery. You don't need to add the optional allow\_search\_engine\_discovery parameter. With Microsoft Edge version 100, setting this policy as a recommended policy also allows users to manually add new search engines from their Microsoft Edge settings.

If you enable this policy, users can't add, remove, or change any search engine in the list. Users can set their default search engine to any search engine in the list.

If you disable or don't configure this policy, users can modify the search engines list as desired.

If the [DefaultSearchProviderSearchURL](defaultsearchprovidersearchurl) policy is set, this policy (ManagedSearchEngines) is ignored. The user must restart their browser to finish applying this policy.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ManagedSearchEngines
- GP name: Manage Search Engines
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"allow_search_engine_discovery": true}, {"is_default": true, "keyword": "example1.com", "name": "Example1", "search_url": "https://www.example1.com/search?q={searchTerms}", "suggest_url": "https://www.example1.com/qbox?query={searchTerms}"}, {"image_search_post_params": "content={imageThumbnail},url={imageURL},sbisrc={SearchSource}", "image_search_url": "https://www.example2.com/images/detail/search?iss=sbiupload", "keyword": "example2.com", "name": "Example2", "search_url": "https://www.example2.com/search?q={searchTerms}", "suggest_url": "https://www.example2.com/qbox?query={searchTerms}"}, {"encoding": "UTF-8", "image_search_url": "https://www.example3.com/images/detail/search?iss=sbiupload", "keyword": "example3.com", "name": "Example3", "search_url": "https://www.example3.com/search?q={searchTerms}", "suggest_url": "https://www.example3.com/qbox?query={searchTerms}"}, {"keyword": "example4.com", "name": "Example4", "search_url": "https://www.example4.com/search?q={searchTerms}"}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: ManagedSearchEngines
- Value type: REG\_SZ

#### Example registry value

```
[{"allow_search_engine_discovery": true}, {"is_default": true, "keyword": "example1.com", "name": "Example1", "search_url": "https://www.example1.com/search?q={searchTerms}", "suggest_url": "https://www.example1.com/qbox?query={searchTerms}"}, {"image_search_post_params": "content={imageThumbnail},url={imageURL},sbisrc={SearchSource}", "image_search_url": "https://www.example2.com/images/detail/search?iss=sbiupload", "keyword": "example2.com", "name": "Example2", "search_url": "https://www.example2.com/search?q={searchTerms}", "suggest_url": "https://www.example2.com/qbox?query={searchTerms}"}, {"encoding": "UTF-8", "image_search_url": "https://www.example3.com/images/detail/search?iss=sbiupload", "keyword": "example3.com", "name": "Example3", "search_url": "https://www.example3.com/search?q={searchTerms}", "suggest_url": "https://www.example3.com/qbox?query={searchTerms}"}, {"keyword": "example4.com", "name": "Example4", "search_url": "https://www.example4.com/search?q={searchTerms}"}]
```

#### Expanded example registry value

```
[
  {
    "allow_search_engine_discovery": true
  },
  {
    "is_default": true,
    "keyword": "example1.com",
    "name": "Example1",
    "search_url": "https://www.example1.com/search?q={searchTerms}",
    "suggest_url": "https://www.example1.com/qbox?query={searchTerms}"
  },
  {
    "image_search_post_params": "content={imageThumbnail},url={imageURL},sbisrc={SearchSource}",
    "image_search_url": "https://www.example2.com/images/detail/search?iss=sbiupload",
    "keyword": "example2.com",
    "name": "Example2",
    "search_url": "https://www.example2.com/search?q={searchTerms}",
    "suggest_url": "https://www.example2.com/qbox?query={searchTerms}"
  },
  {
    "encoding": "UTF-8",
    "image_search_url": "https://www.example3.com/images/detail/search?iss=sbiupload",
    "keyword": "example3.com",
    "name": "Example3",
    "search_url": "https://www.example3.com/search?q={searchTerms}",
    "suggest_url": "https://www.example3.com/qbox?query={searchTerms}"
  },
  {
    "keyword": "example4.com",
    "name": "Example4",
    "search_url": "https://www.example4.com/search?q={searchTerms}"
  }
]
```

## Mac information and settings

- Preference Key name: ManagedSearchEngines
- Example value:

```xml
<key>ManagedSearchEngines</key>
<array>
  <dict>
    <key>allow_search_engine_discovery</key>
    <true/>
  </dict>
  <dict>
    <key>is_default</key>
    <true/>
    <key>keyword</key>
    <string>example1.com</string>
    <key>name</key>
    <string>Example1</string>
    <key>search_url</key>
    <string>https://www.example1.com/search?q={searchTerms}</string>
    <key>suggest_url</key>
    <string>https://www.example1.com/qbox?query={searchTerms}</string>
  </dict>
  <dict>
    <key>image_search_post_params</key>
    <string>content={imageThumbnail},url={imageURL},sbisrc={SearchSource}</string>
    <key>image_search_url</key>
    <string>https://www.example2.com/images/detail/search?iss=sbiupload</string>
    <key>keyword</key>
    <string>example2.com</string>
    <key>name</key>
    <string>Example2</string>
    <key>search_url</key>
    <string>https://www.example2.com/search?q={searchTerms}</string>
    <key>suggest_url</key>
    <string>https://www.example2.com/qbox?query={searchTerms}</string>
  </dict>
  <dict>
    <key>encoding</key>
    <string>UTF-8</string>
    <key>image_search_url</key>
    <string>https://www.example3.com/images/detail/search?iss=sbiupload</string>
    <key>keyword</key>
    <string>example3.com</string>
    <key>name</key>
    <string>Example3</string>
    <key>search_url</key>
    <string>https://www.example3.com/search?q={searchTerms}</string>
    <key>suggest_url</key>
    <string>https://www.example3.com/qbox?query={searchTerms}</string>
  </dict>
  <dict>
    <key>keyword</key>
    <string>example4.com</string>
    <key>name</key>
    <string>Example4</string>
    <key>search_url</key>
    <string>https://www.example4.com/search?q={searchTerms}</string>
  </dict>
</array>
```