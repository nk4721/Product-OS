---
title: Vendor Knowledge Framework
owner: Product Director
reviewer: Solution Architect
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: Governance
domain: Vendors
audience:
  - All Agents
source_of_truth:
  - Official vendor documentation
related_documents:
  - ../docs/document-owners.md
  - ../docs/company/AI-GOVERNANCE.md
---

# Vendor Knowledge Framework

This folder is the shared source of internal knowledge about external platforms, data providers and integration partners.

Vendor knowledge and product documentation must remain separate:

- `04 Vendors/` explains what a vendor provides, how its services behave and how integrations should use them.
- Product folders explain what Product OS builds, sells and supports using that vendor.

## Standard vendor structure

Each vendor should contain:

1. `README.md` — navigation, scope and freshness.
2. `01-PLATFORM-OVERVIEW.md` — capabilities and business use cases.
3. `02-AUTHENTICATION.md` — access, environments and credential handling.
4. `03-API-CATALOG.md` — internally curated capability map.
5. `04-DATA-MODEL.md` — normalized concepts and identifiers.
6. `05-INTEGRATION-PATTERNS.md` — lookup, synchronization, monitoring and caching.
7. `06-SUPEROFFICE-MAPPING.md` — recommended CRM mappings where applicable.
8. `07-ERROR-HANDLING.md` — resilience and operational responses.
9. `08-SECURITY-PRIVACY.md` — privacy, security and contractual controls.
10. `09-KNOWN-LIMITATIONS.md` — assumptions, gaps and unresolved questions.
11. `10-REFERENCES.md` — official sources and review notes.

## Knowledge rules

- Official vendor documentation remains the source of truth for endpoints, schemas, availability and commercial rights.
- Never store production credentials, customer secrets or personal data in this repository.
- Never assume that availability in a vendor platform means the customer is licensed to use it.
- Separate data and products from different suppliers when agreements or licences require it.
- Mark unverified statements as assumptions or open questions.
- Review material before architecture decisions, releases and contract changes.
- Link to official material rather than copying large sections of vendor documentation.

## Metadata requirements

Every document must include YAML metadata with owner, reviewer, status, version, last review date, audience, source of truth and related documents.

## Planned vendors

- Roaring
- Creditsafe
- Dun & Bradstreet
- SuperOffice
- Microsoft
- GetAccept
