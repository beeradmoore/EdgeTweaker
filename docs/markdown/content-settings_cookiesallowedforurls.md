---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CookiesAllowedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/cookiesallowedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow cookies on specific sites'
locale: en-us
document_id: 33b6c59d-5be0-d5b0-8d59-70ae85a00ea5
document_version_independent_id: 33b6c59d-5be0-d5b0-8d59-70ae85a00ea5
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CookiesAllowedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/CookiesAllowedForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 419
asset_id: microsoft-edge-policies/cookiesallowedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CookiesAllowedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 95d11c82-3ecf-125c-94e6-44afe89e17cf
---

# Microsoft Edge Browser Policy Documentation CookiesAllowedForUrls | Microsoft Learn

## Allow cookies on specific sites

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: Not supported

## Description

Define a list of sites, based on URL patterns, that are allowed to set cookies. URL patterns can be a single URL indicating that the site can use cookies on all top-level sites. Patterns can also be two URLs delimited by a comma. The first specifies the site that should be allowed to use cookies. The second specifies the top-level site that the first value should be applied on. If you use a pair of URLs, the first value in the pair supports \*, but the second value doesn't. Using \* for the first value indicates that all sites can use cookies when the second URL is the top-level site.

If you don't configure this policy, the global default value from the [DefaultCookiesSetting](defaultcookiessetting) policy (if set) or the user's personal configuration is used for all sites.

For more information, see the [CookiesBlockedForUrls](cookiesblockedforurls) and [CookiesSessionOnlyForUrls](cookiessessiononlyforurls) policies.

Note there can't be conflicting URL patterns set between these three policies:

- [CookiesBlockedForUrls](cookiesblockedforurls)
- CookiesAllowedForUrls
- [CookiesSessionOnlyForUrls](cookiessessiononlyforurls)

For detailed information about valid URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. \* isn't an accepted value for this policy.

To allow third-party cookies to be set, specify a pair of URL patterns delimited by a comma. The first value in the pair specifies the third-party site that should be allowed to use cookies. The second value in the pair specifies the top-level site that the first value should be applied on. The first value in the pair supports \* but the second value doesn't.

To exclude cookies from being deleted on exit, configure the [SaveCookiesOnExit](savecookiesonexit) policy.

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

- GP unique name: CookiesAllowedForUrls
- GP name: Allow cookies on specific sites
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.contoso.com
```

```
[*.]contoso.edu
```

```
https://loaded-as-third-party.fabrikam.com,https://www.contoso.com
```

```
*,https://www.contoso.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\CookiesAllowedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\CookiesAllowedForUrls\1 =

```
https://www.contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\CookiesAllowedForUrls\2 =

```
[*.]contoso.edu
```

SOFTWARE\Policies\Microsoft\Edge\CookiesAllowedForUrls\3 =

```
https://loaded-as-third-party.fabrikam.com,https://www.contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\CookiesAllowedForUrls\4 =

```
*,https://www.contoso.com
```

## Mac information and settings

- Preference Key name: CookiesAllowedForUrls
- Example value:

```xml
<array>
  <string>https://www.contoso.com</string>
  <string>[*.]contoso.edu</string>
  <string>https://loaded-as-third-party.fabrikam.com,https://www.contoso.com</string>
  <string>*,https://www.contoso.com</string>
</array>
```

## Android information and settings

- Preference Key name: CookiesAllowedForUrls
- Example value:

```
["https://www.contoso.com", "[*.]contoso.edu", "https://loaded-as-third-party.fabrikam.com,https://www.contoso.com", "*,https://www.contoso.com"]
```