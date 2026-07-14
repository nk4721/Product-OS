---
title: Roaring Known Limitations and Open Questions
vendor: Roaring
owner: Product Director
reviewer: Solution Architect
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: Risk Register
domain: Roaring
audience: [Product Director, Discovery Agent, Solution Architect, Backend Developer, QA Agent, Product Marketing]
source_of_truth: [Official Roaring documentation, Customer agreements, Validated product findings]
related_documents: [01-PLATFORM-OVERVIEW.md, 03-API-CATALOG.md, 10-REFERENCES.md]
---
# Known limitations and open questions

## Current limitations

- API names, schemas and commercial packaging may change and must be verified before implementation.
- Capabilities and data quality may differ by country and registry.
- A customer's access may cover only a subset of platform capabilities.
- Vendor data may be delayed, incomplete, ambiguous or inconsistent with CRM data.
- Person, ownership and compliance data may have stricter use and storage restrictions than company data.
- Search may return multiple candidates and requires controlled matching.
- Monitoring does not remove the need for operational review and exception handling.
- External availability and latency are outside Product OS control.

## Open questions for each product

- Which exact APIs and countries are licensed?
- Which identifiers are reliable for matching?
- Which fields may be stored, for how long and for what purpose?
- What are the rate, quota and concurrency limits?
- What are the service-level and support arrangements?
- How are monitoring events delivered, retried and acknowledged?
- Which changes require customer action?
- What is the fallback when the service is unavailable?
- How are false-positive screening matches reviewed?

## Resolution rule

Move an item from assumption to verified knowledge only when an authoritative source or controlled test supports it. Record the source and review date.