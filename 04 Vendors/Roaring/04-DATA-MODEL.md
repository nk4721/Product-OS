---
title: Roaring Normalized Data Model
vendor: Roaring
owner: Data & AI Agent
reviewer: Solution Architect
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: Data Model
domain: Roaring
audience: [Solution Architect, Backend Developer, Data & AI Agent, QA Agent]
source_of_truth: [Official Roaring schemas, Customer data agreement]
related_documents: [03-API-CATALOG.md, 05-INTEGRATION-PATTERNS.md, 06-SUPEROFFICE-MAPPING.md]
---
# Normalized data model

Product code should isolate vendor response models from internal business models. Preserve raw identifiers and provenance while mapping only the fields needed by the use case.

## Core internal entities

### Organization

Recommended fields: vendor identifier, national registration identifier, country, legal name, legal form, status, addresses, industry codes, registration dates and data timestamp.

### Person

Recommended fields: vendor identifier, country, permitted identity attributes, address where lawful, roles and data timestamp. Apply strict purpose, access and retention controls.

### Role or engagement

Connects a person or organization to another organization with role type, start/end dates, status and source timestamp.

### Ownership

Represents owner, owned entity, ownership type, percentage where available, effective dates and source.

### Authority

Represents signatory text, individual signatories or permitted combinations. Treat interpretation as a business/legal concern, not only a UI field.

### Screening result

Contains subject, screening type, match status, confidence/evidence, review state, decision, reviewer and audit timestamps. Never equate a possible match with a confirmed finding.

### Monitoring event

Contains monitored entity, event type, vendor event identifier, occurred/received timestamps, payload reference, processing status and retry count.

## Provenance requirements

Store source vendor, API product, retrieved timestamp, request correlation identifier, country and transformation version when allowed. Distinguish vendor facts from internally derived values.

## Data minimization

Do not persist complete responses by default. Define field-level purpose, retention and deletion before implementation.