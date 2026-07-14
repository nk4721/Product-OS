---
title: Creditsafe Authentication and Environments
vendor: Creditsafe
owner: Solution Architect
reviewer: DevOps & Platform Agent
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: Authentication
domain: Creditsafe
audience: [Solution Architect, Backend Developer, DevOps & Platform Agent, QA Agent]
source_of_truth: [Official Creditsafe documentation and customer credentials]
related_documents: [README.md, 07-ERROR-HANDLING.md, 08-SECURITY-PRIVACY.md]
---

# Authentication and environments

Treat authentication details as configuration that must be verified for the contracted Creditsafe service and environment.

## Rules

- store credentials only in approved secret storage
- keep test and production credentials separate
- never expose credentials to browser code or repository files
- use tenant-scoped configuration and entitlement checks
- log correlation data, not secrets or full sensitive payloads
- rotate credentials according to policy and supplier guidance

Document the confirmed token flow, base URLs, scopes or products, timeout behavior and renewal process in the product-specific deployment configuration.