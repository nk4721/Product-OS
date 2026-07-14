---
title: Creditsafe Data Model
vendor: Creditsafe
owner: Data & AI Agent
reviewer: Solution Architect
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: Data Model
domain: Creditsafe
audience: [Solution Architect, Backend Developer, Data & AI Agent, QA Agent]
source_of_truth: [Official Creditsafe schemas]
related_documents: [03-API-CATALOG.md, 06-SUPEROFFICE-MAPPING.md]
---

# Data model

Keep Creditsafe response contracts supplier-specific. Do not force ratings, limits, statuses or identifiers into a universal cross-supplier model.

## Internal concepts

- company identity and country
- registration and status
- addresses and contact attributes
- credit assessment and report metadata
- financial figures with period and currency
- people and company roles
- monitoring subscription and event
- source timestamp and retrieval timestamp

Preserve provenance, country, currency, period, source field and retrieval time for values written to SuperOffice.