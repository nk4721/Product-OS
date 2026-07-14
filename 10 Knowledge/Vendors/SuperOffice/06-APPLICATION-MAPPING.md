---
title: Product Applications to SuperOffice Mapping
vendor: SuperOffice
owner: Solution Architect
reviewer: Product Director
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: System Mapping
domain: SuperOffice
audience: [Product Director, Solution Architect, Backend Developer, Customer Success, QA Agent]
source_of_truth: [Product requirements, SuperOffice tenant configuration, official documentation]
related_documents: [04-DATA-MODEL.md, 05-INTEGRATION-PATTERNS.md]
---

# Application mapping

Each application must document how its concepts map to SuperOffice entities, fields, documents, panels and permissions.

## Required mapping decisions

- target company, person, activity, sale, project or document entities
- standard fields versus user-defined fields
- create, update, append or read-only behavior
- source-of-truth and conflict handling
- list and preference dependencies
- web-panel placement and navigation context
- role and permission requirements
- audit and rollback expectations

The mapping must be configurable when customer environments differ and must not assume supplier concepts are interchangeable.