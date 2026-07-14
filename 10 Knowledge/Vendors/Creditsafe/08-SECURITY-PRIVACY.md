---
title: Creditsafe Security and Privacy
vendor: Creditsafe
owner: DevOps & Platform Agent
reviewer: Product Director
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: Security and Privacy
domain: Creditsafe
audience: [Product Director, Solution Architect, DevOps & Platform Agent, Data & AI Agent]
source_of_truth: [Customer agreement, privacy requirements, official Creditsafe documentation]
related_documents: [02-AUTHENTICATION.md, 04-DATA-MODEL.md, 09-KNOWN-LIMITATIONS.md]
---

# Security and privacy

- use least privilege for API access and SuperOffice roles
- store secrets in approved encrypted storage
- minimize personal and report data retained in CRM
- apply purpose, retention and access rules per customer and data type
- avoid sensitive payloads in logs, telemetry and support exports
- maintain auditability for lookups, writes, reports and monitoring actions
- separate tenant data and supplier credentials
- confirm contractual storage and redistribution rights before persisting data