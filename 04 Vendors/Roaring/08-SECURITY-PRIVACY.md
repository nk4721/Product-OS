---
title: Roaring Security and Privacy
vendor: Roaring
owner: DevOps & Platform Agent
reviewer: Product Director
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: Security and Privacy
domain: Roaring
audience: [Product Director, Solution Architect, Backend Developer, DevOps & Platform Agent, Data & AI Agent, Customer Success]
source_of_truth: [Customer agreement, Privacy assessment, Official Roaring documentation, Applicable law]
related_documents: [02-AUTHENTICATION.md, 04-DATA-MODEL.md, 06-SUPEROFFICE-MAPPING.md]
---
# Security and privacy

Roaring integrations may process company, person, ownership and compliance information. The legal basis, purpose and allowed handling must be defined per product and customer.

## Mandatory controls

- Document purpose, data categories, recipients, retention and deletion.
- Apply data minimization and role-based access.
- Separate tenants and environments.
- Encrypt data in transit and at rest according to platform policy.
- Keep credentials in a managed secret store.
- Audit access and material data changes without logging sensitive payloads.
- Define handling for data-subject requests where applicable.
- Restrict exports and bulk access.
- Review subprocessors, transfer locations and contractual restrictions.

## Compliance screening

Possible PEP or sanctions matches require controlled human review. The product must distinguish possible, reviewed and confirmed outcomes and preserve decision evidence without presenting automated output as a final legal conclusion.

## Retention

Retention must be field- and purpose-specific. Do not keep complete raw responses merely because storage is technically possible.

## Release gate

A release involving new person data, screening, monitoring or storage requires privacy/security review and confirmation of customer entitlement.