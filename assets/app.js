
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
  document.execCommand('copy');
  ta.remove();
}
async function copyText(id) {
  const text = document.getElementById(id).innerText;
  const statusId = id === 'manualCode' ? 'statusManual' : 'statusOnline';
  try { await navigator.clipboard.writeText(text); } catch { fallbackCopy(text); }
  const s = document.getElementById(statusId);
  s.textContent = 'Código copiado para a área de transferência.';
  setTimeout(() => s.textContent = '', 2500);
}
async function copyAndOpen() {
  const text = document.getElementById('onlineCode').innerText;
  try { await navigator.clipboard.writeText(text); } catch { fallbackCopy(text); }
  window.open('https://onecompiler.com/csharp', '_blank', 'noopener');
  const s = document.getElementById('statusOnline');
  s.textContent = 'Código copiado. Cole-o no OneCompiler e execute.';
  setTimeout(() => s.textContent = '', 3500);
}


async function copyPageLink() {
  const status = document.getElementById('pageLinkStatus');
  const url = window.location.href;
  try { await navigator.clipboard.writeText(url); }
  catch { fallbackCopy(url); }
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
