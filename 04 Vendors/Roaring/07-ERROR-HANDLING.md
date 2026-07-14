---
title: Roaring Error Handling
vendor: Roaring
owner: Backend Developer
reviewer: QA Agent
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: Reliability
domain: Roaring
audience: [Backend Developer, Solution Architect, DevOps & Platform Agent, QA Agent, Customer Success]
source_of_truth: [Official Roaring error documentation, Production observations]
related_documents: [02-AUTHENTICATION.md, 05-INTEGRATION-PATTERNS.md, 09-KNOWN-LIMITATIONS.md]
---
# Error handling

Map vendor responses into a stable internal error model. Confirm exact status codes and error payloads against official documentation.

## Internal error classes

- Authentication or authorization failure
- Customer not entitled to requested product
- Invalid or incomplete request
- Entity not found
- Ambiguous search result
- Rate or quota limit
- Temporary vendor failure
- Timeout or network failure
- Schema or parsing failure
- Data-quality or business-rule conflict

## Response principles

- Give users an actionable message without exposing credentials or sensitive payloads.
- Do not retry invalid requests, denied access or confirmed not-found results.
- Retry only transient failures and only when the operation is safe or idempotent.
- Respect vendor retry instructions where provided.
- Send exhausted background failures to a review queue or dead-letter mechanism.
- Correlate internal logs with vendor request identifiers when available.

## Operational metrics

Track latency, success rate, timeout rate, throttling, authentication failures, parsing failures, retries, queue depth and age of the oldest unprocessed monitoring event.

## Support record

Capture environment, timestamp, internal correlation ID, vendor request ID, capability, country and sanitized error details.