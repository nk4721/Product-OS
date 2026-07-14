---
title: Roaring to SuperOffice Mapping
vendor: Roaring
owner: Solution Architect
reviewer: Product Director
status: Active
version: 2.0
last_reviewed: 2026-07-14
category: System Mapping
domain: Roaring and SuperOffice
audience:
  - Solution Architect
  - Backend Developer
  - Product Director
  - Customer Success
  - QA Agent
source_of_truth:
  - Official Roaring schemas
  - Official SuperOffice documentation
related_documents:
  - 04-DATA-MODEL.md
  - 08-SECURITY-PRIVACY.md
---

# Roaring to SuperOffice mapping

Mapping must be product-specific, configurable and approved before data is written.

## Recommended principles

- Match organizations using country-aware registration identifiers.
- Preserve SuperOffice record identity and user-owned values unless an approved overwrite rule exists.
- Store source, retrieval date and mapping version for imported values.
- Use dedicated fields for selected attributes rather than opaque payload storage.
- Present sensitive person, ownership or compliance information only to authorized users.
- Separate live display from persisted CRM data.
- Record conflicts and allow review instead of silently overwriting.

Each product must maintain a field-level mapping table covering source path, target entity and field, transformation, null handling, overwrite rule, retention and permissions.