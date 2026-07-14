---
title: SuperOffice Authentication and Tenant Context
vendor: SuperOffice
owner: Solution Architect
reviewer: DevOps & Platform Agent
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: Authentication
domain: SuperOffice
audience: [Solution Architect, Backend Developer, DevOps & Platform Agent, QA Agent]
source_of_truth: [Official SuperOffice application and authentication documentation]
related_documents: [README.md, ../../../platform/integration-sdk/README.md, 08-SECURITY-PRIVACY.md]
---

# Authentication and tenant context

Every application must operate in an explicit SuperOffice tenant and user context.

## Rules

- keep application credentials and secrets server-side
- validate tenant identity, user identity, roles and application authorization
- separate customer configuration and data by tenant
- request only required permissions
- handle token expiry and renewal according to the approved application model
- never trust browser-supplied tenant or user identifiers without validation
- log safe correlation and tenant context without exposing tokens

The Integration SDK should centralize reusable authentication and tenant-context behavior.