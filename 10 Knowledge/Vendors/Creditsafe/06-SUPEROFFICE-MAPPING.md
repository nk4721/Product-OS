---
title: Creditsafe to SuperOffice Mapping
vendor: Creditsafe
owner: Solution Architect
reviewer: Product Director
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: System Mapping
domain: Creditsafe
audience: [Solution Architect, Backend Developer, Customer Success, QA Agent]
source_of_truth: [Official Creditsafe schemas, SuperOffice configuration, customer mapping decisions]
related_documents: [04-DATA-MODEL.md, 05-INTEGRATION-PATTERNS.md]
---

# SuperOffice mapping

Map only fields required by the configured workflow. Prefer configurable mappings over hard-coded assumptions.

## Typical destinations

- company identity, name and addresses
- organization number and country
- rating, risk, limit and last retrieval date in user-defined fields
- financial figures with period and currency
- board, signatory and related role information in controlled views or documents
- credit reports as documents where licensed
- monitoring status and event history

Every write must record source, timestamp, previous value and initiating user or job. Destructive overwrites require explicit rules.