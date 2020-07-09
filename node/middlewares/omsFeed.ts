import { EventContext } from '@vtex/api'

import { Clients } from '../clients'

export async function omsFeed(
  ctx: EventContext<Clients>,
  next: () => Promise<any>
) {
  console.warn(ctx.body)
  await next()
}
