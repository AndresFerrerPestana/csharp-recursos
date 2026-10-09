
function showTab(which) {
  const manual = which === 'manual';
  document.getElementById('panelManual').classList.toggle('hidden', !manual);
  document.getElementById('panelOnline').classList.toggle('hidden', manual);
  document.getElementById('tabManual').classList.toggle('active', manual);
  document.getElementById('tabOnline').classList.toggle('active', !manual);
}
function fallbackCopy(text) {
  const ta = document.createElement('textarea');
  ta.value = text;
  document.body.appendChild(ta);
  ta.select();
  const copied = document.execCommand('copy');
  ta.remove();
  if (!copied) throw new Error('A cópia foi bloqueada pelo navegador.');
}
async function copyText(id) {
  const text = document.getElementById(id).innerText;
  const statusId = id === 'manualCode' ? 'statusManual' : 'statusOnline';
  const s = document.getElementById(statusId);
  try {
    try { await navigator.clipboard.writeText(text); } catch { fallbackCopy(text); }
  } catch {
    s.textContent = 'Não foi possível copiar. Selecione o código e use Ctrl+C.';
    return;
  }
  s.textContent = 'Código copiado para a área de transferência.';
  setTimeout(() => s.textContent = '', 2500);
}



async function copyPageLink() {
  const status = document.getElementById('pageLinkStatus');
  const url = window.location.href;
  try {
    try { await navigator.clipboard.writeText(url); } catch { fallbackCopy(url); }
  } catch {
    if (status) status.textContent = 'Não foi possível copiar. Copie o endereço do navegador.';
    return;
  }
  if (status) {
    status.textContent = 'Ligação copiada.';
    setTimeout(() => status.textContent = '', 2200);
  }
}

function filterExercises(value) {
  const q = (value || '').trim().toLowerCase();
  const cards = document.querySelectorAll('[data-exercise-card]');
  let visible = 0;
  cards.forEach(card => {
    const hay = (card.dataset.search || card.innerText).toLowerCase();
    const show = !q || hay.includes(q);
    card.style.display = show ? '' : 'none';
    if (show) visible++;
  });
  const empty = document.getElementById('emptyState');
  if (empty) empty.style.display = visible ? 'none' : 'block';
}
