---
title: Roaring Integration Patterns
vendor: Roaring
owner: Solution Architect
reviewer: Backend Developer
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: Architecture
domain: Roaring
audience: [Solution Architect, Backend Developer, DevOps & Platform Agent, QA Agent]
source_of_truth: [Official Roaring documentation, Product architecture decisions]
related_documents: [02-AUTHENTICATION.md, 04-DATA-MODEL.md, 07-ERROR-HANDLING.md]
---
# Integration patterns

## Live lookup

Use when a user needs current data to complete a decision. Show retrieval time and source. Do not silently overwrite CRM master data.

## Controlled enrichment

Present proposed changes, identify source and allow approved fields to be written. Log old value, new value, user and timestamp where required.

## Batch update

Use background jobs with checkpoints, bounded concurrency, idempotency and restart support. Produce a reconciliation report instead of assuming all records succeeded.

## Monitoring

Separate subscription management, event ingestion and business processing. Deduplicate vendor events and keep processing idempotent. Acknowledge events only according to the confirmed vendor contract.

## Caching

Cache only when contract, purpose and freshness requirements permit. Cache keys must include country and stable vendor identifiers. Store expiry and source timestamp.

## Adapter boundary

Use a Roaring adapter that translates vendor schemas and errors into internal contracts. Product logic must not depend directly on vendor-specific response structures.

## Auditability

Generate correlation identifiers across inbound request, vendor call, transformation and CRM update. Avoid logging sensitive payloads.

## Resilience

Use explicit timeouts, safe retries with backoff and jitter, circuit breaking, queue-based recovery for background work and clear user-facing partial-failure states.