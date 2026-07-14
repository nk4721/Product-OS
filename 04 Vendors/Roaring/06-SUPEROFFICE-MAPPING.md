---
title: Roaring to SuperOffice Mapping
vendor: Roaring
owner: Solution Architect
reviewer: Product Director
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: CRM Mapping
domain: Roaring and SuperOffice
audience: [Product Director, Solution Architect, Backend Developer, Customer Success, QA Agent]
source_of_truth: [Official Roaring schemas, SuperOffice configuration, Customer mapping decision]
related_documents: [04-DATA-MODEL.md, 05-INTEGRATION-PATTERNS.md, 08-SECURITY-PRIVACY.md]
---
# Roaring to SuperOffice mapping

Mappings are customer- and product-specific. This document defines the decision method, not a universal field map.

## Recommended targets

- Company entity: legal name, organization number, status, legal form, addresses and selected business attributes.
- Person entity: only approved identity/contact attributes with a documented purpose.
- Relations or custom structures: board roles, ownership, engagements and signatory information when the product supports them.
- More fields: stable, searchable values that users need in selections, dashboards or workflows.
- Documents or links: reports where licence and retention allow storage.
- Activities or notifications: monitoring events that require user action.

## Mapping rules

1. Prefer stable identifiers over names for matching.
2. Include country when interpreting national identifiers.
3. Define which system owns each field.
4. Distinguish preview, user-approved update and automatic synchronization.
5. Never overwrite manually maintained data without an explicit rule.
6. Store source and last-updated time for vendor-derived fields.
7. Avoid creating one CRM field per raw vendor attribute.
8. Preserve supplier separation where contracts require it.

## Required mapping specification

For each field document: vendor path, internal field, SuperOffice target, type, transformation, null behaviour, ownership, update mode, freshness, permission, retention and test cases.

## Matching strategy

Use organization number plus country when valid. Define controlled fallback matching and a manual review path for ambiguous records. Never merge records solely on a similar name.