---
title: Roaring Authentication and Environments
vendor: Roaring
owner: Solution Architect
reviewer: DevOps & Platform Agent
status: Active
version: 2.0
last_reviewed: 2026-07-14
category: Authentication
domain: Roaring
audience:
  - Solution Architect
  - Backend Developer
  - DevOps & Platform Agent
  - QA Agent
source_of_truth:
  - Official Roaring authentication documentation
  - Applicable customer agreement
related_documents:
  - 05-INTEGRATION-PATTERNS.md
  - 08-SECURITY-PRIVACY.md
---

# Authentication and environments

Treat credentials, tokens and environment configuration as secrets. Never store them in source control, logs, screenshots or documentation examples.

Before implementation, verify the current authentication flow, token lifetime, scopes, base URLs, sandbox availability and environment-specific credentials in official documentation.

## Internal requirements

- Use a managed secret store.
- Separate development, test and production credentials.
- Request only required scopes and products.
- Refresh or reacquire tokens safely.
- Redact authorization headers and sensitive payloads from logs.
- Rotate credentials according to policy and after suspected exposure.
- Fail safely when authentication is unavailable.