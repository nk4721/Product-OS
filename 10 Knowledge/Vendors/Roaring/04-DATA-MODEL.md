---
title: Roaring Normalized Data Model
vendor: Roaring
owner: Data & AI Agent
reviewer: Solution Architect
status: Active
version: 2.0
last_reviewed: 2026-07-14
category: Data Model
domain: Roaring
audience:
  - Data & AI Agent
  - Solution Architect
  - Backend Developer
  - QA Agent
source_of_truth:
  - Official Roaring schemas
related_documents:
  - 03-API-CATALOG.md
  - 06-SUPEROFFICE-MAPPING.md
---

# Normalized data model

Product code should translate vendor responses into internal domain models instead of coupling workflows directly to raw payloads.

## Core concepts

- Organization: vendor identifiers, registration number, legal name, status, legal form and addresses.
- Person: identifiers permitted for the stated purpose, name and relevant roles.
- Role: relationship between a person and organization, including source and validity.
- Ownership: owner, owned entity, share or control information and source date.
- Compliance result: screening type, result, timestamp, source and review state.
- Monitoring event: entity, event type, detected time, payload reference and processing status.

Persist provenance, retrieval time and vendor product alongside stored values. Do not treat absent values as negative facts, and do not merge country-specific identifiers without explicit normalization rules.